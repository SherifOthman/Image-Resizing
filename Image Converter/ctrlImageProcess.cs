using ImageConverterLib;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Converter
{
    public partial class ctrlImageProcess : UserControl
    {
        private MagickFormat imageFormat;

        public int GroupNumber { get; set; }
        private Size imagesSize;
        private Queue<string> imagesQueue;

        public ctrlImageProcess()
        {

            InitializeComponent();
        }

        public ctrlImageProcess(int groupNumber, Size imagesSize, Queue<string> imagesQueue, MagickFormat convertTo) : this()
        {
            this.GroupNumber = groupNumber;
            this.imagesSize = imagesSize;
            this.imagesQueue = imagesQueue;
            this.imageFormat = convertTo;
        }

        private Size _GetNewSize()
        {
            if (txtHeight.Text.Trim() != "" && txtWidth.Text.Trim() != "")
            {
                return new Size(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            }
            else
            {
                return imagesSize;
            }
        }

        private void LockControls()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => LockControls()));
                return;
            }

            txtHeight.Enabled = false;
            txtWidth.Enabled = false;
        }

        private string _CreateNewFolderWithSizeToSave(string folderPath)
        {
            Size newSize = _GetNewSize();

            string newFolderPath = $"{folderPath}\\{newSize.Width} X {newSize.Height}";

            if (!Directory.Exists(newFolderPath))
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(newFolderPath);
                directoryInfo.Attributes = FileAttributes.Normal;

            }

            return newFolderPath;
        }

        public void updateCurrentProgress(int counter)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)(() => updateCurrentProgress(counter)));
                return;
            }

            int percentage = (int)(((float)counter / Convert.ToInt32(lblTotalImages.Text)) * 100);
            guna2CircleProgressBar1.Value = percentage;
        }

        public async Task StartConversion(string folderPathToSave, CancellationToken token, Action mainProgress)
        {
            LockControls();

            string newFolderWithSize = _CreateNewFolderWithSizeToSave(folderPathToSave);
            Size newSize = _GetNewSize();

            int counter = 1;

            List<Task> allTasks = new List<Task>();

            Queue<string> copyQueue = new Queue<string>(imagesQueue);

            while (copyQueue.Count > 0)
            {

                using (FileStream stream = new FileStream(copyQueue.Peek(), FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (MagickImage magickImage = new MagickImage(stream))
                    {
                        magickImage.Resize(newSize.Width, newSize.Height);
                        //   magickImage.FilterType = FilterType.Lanczos2Sharp;
                        magickImage.Format = imageFormat;
                        magickImage.Quality = 100;
                        magickImage.Sharpen();


                        //magickImage.Despeckle();
                        //magickImage.Contrast();
                        //magickImage.ReduceNoise();
                        //magickImage.Strip();

                        //magickImage.Sharpen();
                        //magickImage.Enhance();

                        allTasks.Add(magickImage.WriteAsync($"{newFolderWithSize}\\{counter}.{imageFormat}"));
                        copyQueue.Dequeue();

                        updateCurrentProgress(counter);

                        counter++;
                        mainProgress?.Invoke();

                        token.ThrowIfCancellationRequested();
                    }
                }
            }

            await Task.WhenAll(allTasks);
        }

        //Events
        private void UserControl1_Load(object sender, EventArgs e)
        {
            lblGroupNumber.Text = GroupNumber.ToString();
            lblSize.Text = $"{imagesSize.Width} X {imagesSize.Height}";
            lblTotalImages.Text = imagesQueue.Count.ToString();
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txtWidth_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txtWidth_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWidth.Text))
            {
                int newWidth = Convert.ToInt32(txtWidth.Text);
                txtHeight.Text = ImageHelper.GetNewHeight(imagesSize.Width, imagesSize.Height, newWidth).ToString();
            }
            else
            {
                txtHeight.Text = "";
            }
        }

        private void txtHeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHeight.Text))
            {
                int newHeight = Convert.ToInt32(txtHeight.Text);
                txtWidth.Text = ImageHelper.GetNewWidth(imagesSize.Width, imagesSize.Height, newHeight).ToString();
            }
            else
            {
                txtWidth.Text = "";
            }

        }
    }
}
