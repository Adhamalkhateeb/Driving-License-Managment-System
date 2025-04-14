namespace DVLD
{
    partial class frmDrivingLicenseApplicationInfo
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
            ctrlDrivingLicenseApplicationInfo1 = new ctrlDrivingLicenseApplicationInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Arial Black", 12F);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(4, 12);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(5, 3, 5, 3);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(1053, 448);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 11F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(898, 410);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(152, 50);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1061, 476);
            Controls.Add(btnClose);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmDrivingLicenseApplicationInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driving License Application Info";
            Load += frmDrivingLicenseApplicationInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Button btnClose;
    }
}