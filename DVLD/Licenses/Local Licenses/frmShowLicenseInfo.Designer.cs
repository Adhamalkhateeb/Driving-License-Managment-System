namespace DVLD
{
    partial class frmShowLicenseInfo
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
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Font = new Font("Arial Black", 12F);
            ctrlDriverLicenseInfo1.Location = new Point(9, 217);
            ctrlDriverLicenseInfo1.Margin = new Padding(5, 4, 5, 4);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1050, 401);
            ctrlDriverLicenseInfo1.TabIndex = 0;
          
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(309, 154);
            label1.Name = "label1";
            label1.Size = new Size(458, 59);
            label1.TabIndex = 2;
            label1.Text = "Driver License Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseView_400;
            pictureBox1.Location = new Point(401, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.cross__1_;
            btnClose.Location = new Point(931, 612);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 53);
            btnClose.TabIndex = 8;
            btnClose.Text = " Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1068, 675);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ctrlDriverLicenseInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowLicenseInfo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show License Info";
            Load += frmShowLicenseInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnClose;
    }
}