
namespace BlueStacks5BackupAndRestore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbBSInstallLocation = new System.Windows.Forms.TextBox();
            this.buttonBlueStacksInstall = new System.Windows.Forms.Button();
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.checkBoxRestore = new System.Windows.Forms.CheckBox();
            this.labelBackup = new System.Windows.Forms.Label();
            this.tbBackupLocation = new System.Windows.Forms.TextBox();
            this.buttonPickBackup = new System.Windows.Forms.Button();
            this.buttonPickRestore = new System.Windows.Forms.Button();
            this.tbRestoreFile = new System.Windows.Forms.TextBox();
            this.labelRestore = new System.Windows.Forms.Label();
            this.instanceListBox = new System.Windows.Forms.ListBox();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.tbException = new System.Windows.Forms.TextBox();
            this.fbdBlueStacksInstall = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdBackupLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BlueStacks5 Install Location";
            // 
            // tbBSInstallLocation
            // 
            this.tbBSInstallLocation.Location = new System.Drawing.Point(160, 10);
            this.tbBSInstallLocation.Name = "tbBSInstallLocation";
            this.tbBSInstallLocation.Size = new System.Drawing.Size(438, 20);
            this.tbBSInstallLocation.TabIndex = 2;
            this.tbBSInstallLocation.Leave += new System.EventHandler(this.tbBSInstallLocation_Leave);
            // 
            // buttonBlueStacksInstall
            // 
            this.buttonBlueStacksInstall.Location = new System.Drawing.Point(604, 8);
            this.buttonBlueStacksInstall.Name = "buttonBlueStacksInstall";
            this.buttonBlueStacksInstall.Size = new System.Drawing.Size(26, 23);
            this.buttonBlueStacksInstall.TabIndex = 1;
            this.buttonBlueStacksInstall.Text = "...";
            this.buttonBlueStacksInstall.UseVisualStyleBackColor = true;
            this.buttonBlueStacksInstall.Click += new System.EventHandler(this.buttonBlueStacksInstall_Click);
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.Location = new System.Drawing.Point(16, 46);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(63, 17);
            this.checkBoxBackup.TabIndex = 3;
            this.checkBoxBackup.Text = "Backup";
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            this.checkBoxBackup.Click += new System.EventHandler(this.checkBoxBackup_Click);
            // 
            // checkBoxRestore
            // 
            this.checkBoxRestore.AutoSize = true;
            this.checkBoxRestore.Location = new System.Drawing.Point(16, 76);
            this.checkBoxRestore.Name = "checkBoxRestore";
            this.checkBoxRestore.Size = new System.Drawing.Size(63, 17);
            this.checkBoxRestore.TabIndex = 4;
            this.checkBoxRestore.Text = "Restore";
            this.checkBoxRestore.UseVisualStyleBackColor = true;
            this.checkBoxRestore.Click += new System.EventHandler(this.checkBoxRestore_Click);
            // 
            // labelBackup
            // 
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(85, 48);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(88, 13);
            this.labelBackup.TabIndex = 5;
            this.labelBackup.Text = "Backup Location";
            this.labelBackup.Visible = false;
            // 
            // tbBackupLocation
            // 
            this.tbBackupLocation.Location = new System.Drawing.Point(179, 45);
            this.tbBackupLocation.Name = "tbBackupLocation";
            this.tbBackupLocation.Size = new System.Drawing.Size(419, 20);
            this.tbBackupLocation.TabIndex = 6;
            this.tbBackupLocation.Visible = false;
            this.tbBackupLocation.Leave += new System.EventHandler(this.tbBackupLocation_Leave);
            // 
            // buttonPickBackup
            // 
            this.buttonPickBackup.Location = new System.Drawing.Point(604, 43);
            this.buttonPickBackup.Name = "buttonPickBackup";
            this.buttonPickBackup.Size = new System.Drawing.Size(26, 23);
            this.buttonPickBackup.TabIndex = 7;
            this.buttonPickBackup.Text = "...";
            this.buttonPickBackup.UseVisualStyleBackColor = true;
            this.buttonPickBackup.Visible = false;
            this.buttonPickBackup.Click += new System.EventHandler(this.buttonPickBackup_Click);
            // 
            // buttonPickRestore
            // 
            this.buttonPickRestore.Location = new System.Drawing.Point(604, 72);
            this.buttonPickRestore.Name = "buttonPickRestore";
            this.buttonPickRestore.Size = new System.Drawing.Size(26, 23);
            this.buttonPickRestore.TabIndex = 10;
            this.buttonPickRestore.Text = "...";
            this.buttonPickRestore.UseVisualStyleBackColor = true;
            this.buttonPickRestore.Visible = false;
            this.buttonPickRestore.Click += new System.EventHandler(this.buttonPickRestore_Click);
            // 
            // tbRestoreFile
            // 
            this.tbRestoreFile.Location = new System.Drawing.Point(179, 74);
            this.tbRestoreFile.Name = "tbRestoreFile";
            this.tbRestoreFile.Size = new System.Drawing.Size(419, 20);
            this.tbRestoreFile.TabIndex = 9;
            this.tbRestoreFile.Visible = false;
            // 
            // labelRestore
            // 
            this.labelRestore.AutoSize = true;
            this.labelRestore.Location = new System.Drawing.Point(85, 77);
            this.labelRestore.Name = "labelRestore";
            this.labelRestore.Size = new System.Drawing.Size(63, 13);
            this.labelRestore.TabIndex = 8;
            this.labelRestore.Text = "Restore File";
            this.labelRestore.Visible = false;
            // 
            // instanceListBox
            // 
            this.instanceListBox.FormattingEnabled = true;
            this.instanceListBox.Location = new System.Drawing.Point(16, 110);
            this.instanceListBox.Name = "instanceListBox";
            this.instanceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.instanceListBox.Size = new System.Drawing.Size(297, 186);
            this.instanceListBox.TabIndex = 11;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Enabled = false;
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.Location = new System.Drawing.Point(399, 110);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(231, 86);
            this.buttonBackup.TabIndex = 12;
            this.buttonBackup.Text = "BACKUP";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Enabled = false;
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.Location = new System.Drawing.Point(399, 210);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(231, 86);
            this.buttonRestore.TabIndex = 13;
            this.buttonRestore.Text = "RESTORE";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // tbException
            // 
            this.tbException.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbException.ForeColor = System.Drawing.Color.Red;
            this.tbException.Location = new System.Drawing.Point(16, 110);
            this.tbException.Multiline = true;
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(297, 186);
            this.tbException.TabIndex = 14;
            this.tbException.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(319, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(319, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 315);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbException);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.instanceListBox);
            this.Controls.Add(this.buttonPickRestore);
            this.Controls.Add(this.tbRestoreFile);
            this.Controls.Add(this.labelRestore);
            this.Controls.Add(this.buttonPickBackup);
            this.Controls.Add(this.tbBackupLocation);
            this.Controls.Add(this.labelBackup);
            this.Controls.Add(this.checkBoxRestore);
            this.Controls.Add(this.checkBoxBackup);
            this.Controls.Add(this.buttonBlueStacksInstall);
            this.Controls.Add(this.tbBSInstallLocation);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BlueStacks5 Backup and Restore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBSInstallLocation;
        private System.Windows.Forms.Button buttonBlueStacksInstall;
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.CheckBox checkBoxRestore;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.TextBox tbBackupLocation;
        private System.Windows.Forms.Button buttonPickBackup;
        private System.Windows.Forms.Button buttonPickRestore;
        private System.Windows.Forms.TextBox tbRestoreFile;
        private System.Windows.Forms.Label labelRestore;
        private System.Windows.Forms.ListBox instanceListBox;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.FolderBrowserDialog fbdBlueStacksInstall;
        private System.Windows.Forms.FolderBrowserDialog fbdBackupLocation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

