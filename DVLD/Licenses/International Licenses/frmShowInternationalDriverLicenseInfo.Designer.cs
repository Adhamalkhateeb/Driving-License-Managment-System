namespace DVLD
{
    partial class frmShowInternationalDriverLicenseInfo
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
            label1 = new Label();
            btnClose = new Button();
            ctrlInternationalLicenseInfo1 = new ctrlInternationalLicenseInfo();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(208, 154);
            label1.Name = "label1";
            label1.Size = new Size(632, 59);
            label1.TabIndex = 4;
            label1.Text = " International License Info\r\n";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(920, 529);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 50);
            btnClose.TabIndex = 40;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlInternationalLicenseInfo1
            // 
            ctrlInternationalLicenseInfo1.Location = new Point(2, 216);
            ctrlInternationalLicenseInfo1.Name = "ctrlInternationalLicenseInfo1";
            ctrlInternationalLicenseInfo1.Size = new Size(1046, 310);
            ctrlInternationalLicenseInfo1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LicenseView_400;
            pictureBox1.Location = new Point(387, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // frmShowInternationalDriverLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1049, 595);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlInternationalLicenseInfo1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmShowInternationalDriverLicenseInfo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm Show International Driver License Info";
            Load += frmShowInternationalDriverLicenseInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnClose;
        private ctrlInternationalLicenseInfo ctrlInternationalLicenseInfo1;
        private PictureBox pictureBox1;
    }
}