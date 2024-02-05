namespace Image_Converter
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnChooseFolder = new Guna.UI2.WinForms.Guna2Button();
            this.txtFolderPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.cbImageFormat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalImages = new System.Windows.Forms.Label();
            this.lblConvertedImages = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblSpentTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRemaningTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.panleProggress = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSaveTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveTo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panleFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProcessState = new System.Windows.Forms.Label();
            this.panleProggress.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChooseFolder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChooseFolder.ForeColor = System.Drawing.Color.White;
            this.btnChooseFolder.Location = new System.Drawing.Point(21, 12);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(133, 45);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.AllowDrop = true;
            this.txtFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFolderPath.DefaultText = "";
            this.txtFolderPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFolderPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFolderPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFolderPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFolderPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFolderPath.ForeColor = System.Drawing.Color.Black;
            this.txtFolderPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFolderPath.Location = new System.Drawing.Point(172, 12);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.PasswordChar = '\0';
            this.txtFolderPath.PlaceholderText = "";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.SelectedText = "";
            this.txtFolderPath.Size = new System.Drawing.Size(280, 45);
            this.txtFolderPath.TabIndex = 2;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2VSeparator1.FillThickness = 3;
            this.guna2VSeparator1.Location = new System.Drawing.Point(458, 12);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(17, 538);
            this.guna2VSeparator1.TabIndex = 3;
            // 
            // cbImageFormat
            // 
            this.cbImageFormat.AutoCompleteCustomSource.AddRange(new string[] {
            "JPG",
            "PNG",
            "dfg",
            "dfg"});
            this.cbImageFormat.BackColor = System.Drawing.Color.Transparent;
            this.cbImageFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageFormat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbImageFormat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbImageFormat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbImageFormat.ForeColor = System.Drawing.Color.Black;
            this.cbImageFormat.ItemHeight = 30;
            this.cbImageFormat.Items.AddRange(new object[] {
            "PNG",
            "JPG"});
            this.cbImageFormat.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbImageFormat.Location = new System.Drawing.Point(175, 136);
            this.cbImageFormat.Name = "cbImageFormat";
            this.cbImageFormat.Size = new System.Drawing.Size(140, 36);
            this.cbImageFormat.StartIndex = 1;
            this.cbImageFormat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Image Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(140, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Images: ";
            // 
            // lblTotalImages
            // 
            this.lblTotalImages.AutoSize = true;
            this.lblTotalImages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalImages.ForeColor = System.Drawing.Color.Black;
            this.lblTotalImages.Location = new System.Drawing.Point(245, 11);
            this.lblTotalImages.Name = "lblTotalImages";
            this.lblTotalImages.Size = new System.Drawing.Size(23, 25);
            this.lblTotalImages.TabIndex = 7;
            this.lblTotalImages.Text = "0";
            // 
            // lblConvertedImages
            // 
            this.lblConvertedImages.AutoSize = true;
            this.lblConvertedImages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConvertedImages.Location = new System.Drawing.Point(151, 11);
            this.lblConvertedImages.Name = "lblConvertedImages";
            this.lblConvertedImages.Size = new System.Drawing.Size(17, 19);
            this.lblConvertedImages.TabIndex = 9;
            this.lblConvertedImages.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Converted Images: ";
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2ProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(14, 35);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(251)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.Navy;
            this.guna2ProgressBar1.ShowText = true;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(420, 30);
            this.guna2ProgressBar1.TabIndex = 10;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblSpentTime
            // 
            this.lblSpentTime.AutoSize = true;
            this.lblSpentTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpentTime.Location = new System.Drawing.Point(98, 83);
            this.lblSpentTime.Name = "lblSpentTime";
            this.lblSpentTime.Size = new System.Drawing.Size(17, 19);
            this.lblSpentTime.TabIndex = 12;
            this.lblSpentTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(10, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Time spent:";
            // 
            // lblRemaningTime
            // 
            this.lblRemaningTime.AutoSize = true;
            this.lblRemaningTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemaningTime.Location = new System.Drawing.Point(357, 83);
            this.lblRemaningTime.Name = "lblRemaningTime";
            this.lblRemaningTime.Size = new System.Drawing.Size(17, 19);
            this.lblRemaningTime.TabIndex = 15;
            this.lblRemaningTime.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(234, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Remaning Time:";
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 10;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(75)))), ((int)(((byte)(251)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(21, 216);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 45);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Convert";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panleProggress
            // 
            this.panleProggress.Controls.Add(this.label5);
            this.panleProggress.Controls.Add(this.lblRemaningTime);
            this.panleProggress.Controls.Add(this.lblConvertedImages);
            this.panleProggress.Controls.Add(this.label11);
            this.panleProggress.Controls.Add(this.guna2ProgressBar1);
            this.panleProggress.Controls.Add(this.label7);
            this.panleProggress.Controls.Add(this.lblSpentTime);
            this.panleProggress.Location = new System.Drawing.Point(8, 432);
            this.panleProggress.Name = "panleProggress";
            this.panleProggress.Size = new System.Drawing.Size(446, 118);
            this.panleProggress.TabIndex = 18;
            this.panleProggress.Visible = false;
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.AllowDrop = true;
            this.txtSaveTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaveTo.DefaultText = "";
            this.txtSaveTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSaveTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSaveTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaveTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaveTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaveTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSaveTo.ForeColor = System.Drawing.Color.Black;
            this.txtSaveTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaveTo.Location = new System.Drawing.Point(172, 76);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.PasswordChar = '\0';
            this.txtSaveTo.PlaceholderText = "";
            this.txtSaveTo.ReadOnly = true;
            this.txtSaveTo.SelectedText = "";
            this.txtSaveTo.Size = new System.Drawing.Size(280, 45);
            this.txtSaveTo.TabIndex = 20;
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveTo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveTo.ForeColor = System.Drawing.Color.White;
            this.btnSaveTo.Location = new System.Drawing.Point(21, 76);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Size = new System.Drawing.Size(133, 45);
            this.btnSaveTo.TabIndex = 19;
            this.btnSaveTo.Text = "Save To";
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.lblTotalImages);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(481, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 10;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(457, 56);
            this.guna2ShadowPanel1.TabIndex = 23;
            // 
            // panleFlow
            // 
            this.panleFlow.AutoScroll = true;
            this.panleFlow.Location = new System.Drawing.Point(481, 63);
            this.panleFlow.Name = "panleFlow";
            this.panleFlow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panleFlow.Size = new System.Drawing.Size(457, 476);
            this.panleFlow.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(244, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 45);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(18, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Process State: ";
            // 
            // lblProcessState
            // 
            this.lblProcessState.AutoSize = true;
            this.lblProcessState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProcessState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProcessState.Location = new System.Drawing.Point(123, 332);
            this.lblProcessState.Name = "lblProcessState";
            this.lblProcessState.Size = new System.Drawing.Size(60, 19);
            this.lblProcessState.TabIndex = 25;
            this.lblProcessState.Text = "Waiting";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(974, 562);
            this.Controls.Add(this.lblProcessState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panleFlow);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.txtSaveTo);
            this.Controls.Add(this.btnSaveTo);
            this.Controls.Add(this.panleProggress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbImageFormat);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnChooseFolder);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panleProggress.ResumeLayout(false);
            this.panleProggress.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnChooseFolder;
        private Guna.UI2.WinForms.Guna2TextBox txtFolderPath;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbImageFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalImages;
        private System.Windows.Forms.Label lblConvertedImages;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label lblSpentTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRemaningTime;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Panel panleProggress;
        private Guna.UI2.WinForms.Guna2TextBox txtSaveTo;
        private Guna.UI2.WinForms.Guna2Button btnSaveTo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.FlowLayoutPanel panleFlow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProcessState;
    }
}

