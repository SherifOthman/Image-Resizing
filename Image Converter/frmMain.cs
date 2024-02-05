using Image_Converter.Properties;
using ImageConverterLib;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Converter
{

    public partial class frmMain : Form
    {
        private enum enProcessType { LoadImages, ConvertImages }

        private CancellationTokenSource cts;
        private int totalFinishedImages = 0;
        private Stopwatch stopWatch;
        private enProcessType currentProcess;

        public frmMain()
        {
            InitializeComponent();
            InitializeNotifyIcon();

        }


        private void DisplayNotification(string title, string message)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void UpdateMainProgress()
        {

            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() => UpdateMainProgress()));
                return;
            }

            totalFinishedImages++;

            lblConvertedImages.Text = totalFinishedImages + "\\" + lblTotalImages.Text;
            guna2ProgressBar1.Value = _CalculatePercentage(); ;
            // lblSpentTime.Text = _CalculateSpentTime();
            //  lblRemaningTime.Text = _CalculateRemainingTime();
        }

        private Task StartConversion()
        {
            cts = new CancellationTokenSource();
            return Task.Run(async () =>
              {
                  foreach (Control control in panleFlow.Controls)
                  {
                      if (control is ctrlImageProcess)
                      {
                          await ((ctrlImageProcess)control).StartConversion(txtSaveTo.Text, cts.Token, UpdateMainProgress);
                      }
                  }
              }, cts.Token);
        }

        private async Task _LoadImagesIntoForm(string directoryPath, CancellationToken token)
        {
            string[] images = await Task.Run(() => ImageHelper.GetImagesFromDirectory(directoryPath, token));

            if (images == null)
            {
                Tools.ShowMessage("Empty File!", "The file that you selected is empty", this);
                return;
            }

            lblTotalImages.Text = images?.Length.ToString();

            Dictionary<Size, Queue<string>> qImages = await Task.Run(() => ImageProcessing.GetImagesSize(images, token));

            _ShowImageProcesses(qImages);
        }

        private void _ShowImageProcesses(Dictionary<Size, Queue<string>> dicImages)
        {
            panleFlow.Controls.Clear();

            int counter = 0;
            foreach (var item in dicImages)
            {
                counter++;
                ctrlImageProcess userControls = new ctrlImageProcess(counter, item.Key, item.Value, _GetImageFormat());
                panleFlow.Controls.Add(userControls);
                userControls.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = ((string[])e.Data.GetData(DataFormats.FileDrop, false));

            txtFolderPath.Text = files[0];
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private async void btnChooseFolder_Click(object sender, EventArgs e)
        {

            if (cts != null)
            {
                Tools.ShowMessage("Running process!", "There is running process. if you want to cancel it press Cancel button.?", this);
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath = Settings.Default.LastOpenedFolder;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
                Settings.Default.LastOpenedFolder = txtFolderPath.Text;
                Settings.Default.Save();
                _RestForm();

                try
                {
                    panleFlow.Controls.Add(new ctrlWaiting());
                    cts = new CancellationTokenSource();

                    lblProcessState.Text = "Loading Images...";
                    currentProcess = enProcessType.LoadImages;
                    await _LoadImagesIntoForm(folderBrowserDialog.SelectedPath, cts.Token);
                    lblProcessState.Text = "Waiting";
                }

                catch (OperationCanceledException ex)
                {
                    lblProcessState.Text = "Canceled";
                    //  MessageBox.Show(ex.Message);
                }
                finally
                {
                    cts.Dispose();
                    cts = null;
                }

            }
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            if (txtFolderPath.Text == "")
            {
                Tools.ShowMessage("Select folder", "Select images folder first!", this);
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.SelectedPath = Settings.Default.LastSavePath;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSaveTo.Text = folderBrowserDialog.SelectedPath;
                Settings.Default.LastSavePath = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {

            if (txtSaveTo.Text.Trim() == "")
            {
                Tools.ShowWarningMessage("Unexpected path!", "Please, select folder to save to", this);
                return;
            }

            if (cts != null && currentProcess == enProcessType.LoadImages)
            {
                Tools.ShowMessage("Wait!", "Please wait until loading images to finish", this);
                return;
            }

            if (lblTotalImages.Text == "0")
            {
                Tools.ShowMessage("No images!", "There is no images to convert, select another folder", this);
                return;
            }

            panleProggress.Visible = true;
            _ResetProgressPanel();
            stopWatch.Restart();
            stopWatch.Start();
            timer1.Start();
            lblProcessState.Text = "Converting images...";
            currentProcess = enProcessType.ConvertImages;

            try
            {
                cts = new CancellationTokenSource();
                Task t = Task.Run(() => StartConversion());
                await t;
                stopWatch.Stop();
                timer1.Stop();

                if (t.IsCompleted)
                {
                    lblProcessState.Text = "Completed";
                    Tools.ShowMessage("Done", "Images have converted successfully", this);
                    //  DisplayNotification("Images have converted successfully", "If you want to open the file, press double click");
                }
            }
            catch (OperationCanceledException ex)
            {
                lblProcessState.Text = "Canceled";
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                cts.Dispose();
                cts = null;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cts == null)
            {
                Tools.ShowMessage("No running", "There is no running process", this);
                return;
            }

            cts.Cancel();
            timer1.Stop();
            stopWatch.Stop();

            if (currentProcess == enProcessType.LoadImages)
            {
                _RestForm();
            }
        }

        // Helper functions (Extentions) 

        private MagickFormat _GetImageFormat()
        {
   
            switch (cbImageFormat.SelectedItem.ToString())
            {
                case "PNG":
                    return MagickFormat.Png;

                case "JPG":
                    return MagickFormat.Jpg;
            }

            return MagickFormat.Jpg;
        }

        private void _RestForm()
        {
            panleFlow.Controls.Clear();
            lblTotalImages.Text = "0";

            panleProggress.Visible = false;
            _ResetProgressPanel();
        }

        private void _ResetProgressPanel()
        {
            lblConvertedImages.Text = "0";
            lblRemaningTime.Text = "0";
            lblSpentTime.Text = "0";
            guna2ProgressBar1.Value = 0;
            totalFinishedImages = 0;
        }

        private int _CalculatePercentage()
        {
            return (int)((float)totalFinishedImages / Convert.ToInt32(lblTotalImages.Text) * 100);
        }

        private string _CalculateSpentTime()
        {
            TimeSpan spentTime = TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds);
            return $"{(int)spentTime.Minutes:0}:{spentTime.Seconds:00}";
        }

        private string _CalculateRemainingTime()
        {

            // Calculate the average time per item
            double averageTimePerItem = TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds).TotalSeconds / totalFinishedImages;

            // Calculate the remaining items
            int remainingItems = Convert.ToInt32(lblTotalImages.Text) - totalFinishedImages;

            // Calculate the remaining time
            int remainingTimeSeconds = (int)(remainingItems * averageTimePerItem);

            TimeSpan remainingTimeSpan = TimeSpan.FromSeconds(remainingTimeSeconds);

            return $"{remainingTimeSpan.Minutes:0}: {remainingTimeSpan.Seconds:00}";
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Process.Start(txtSaveTo.Text);
        }

        private void InitializeNotifyIcon()
        {
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSpentTime.Text = _CalculateSpentTime();
            lblRemaningTime.Text = _CalculateRemainingTime();
        }


    }

}

