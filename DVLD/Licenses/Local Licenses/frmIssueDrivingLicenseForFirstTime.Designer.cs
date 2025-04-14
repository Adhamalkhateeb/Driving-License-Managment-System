namespace DVLD
{
    partial class frmIssueDrivingLicenseForFirstTime
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtNotes = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Arial Black", 12F);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(0, 93);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(5, 3, 5, 3);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(1056, 396);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 492);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 1;
            label1.Text = "Notes :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contract;
            pictureBox1.Location = new Point(104, 492);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(179, 494);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(864, 114);
            txtNotes.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(765, 618);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 57);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Black", 10F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(906, 618);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 57);
            btnSave.TabIndex = 38;
            btnSave.Text = "Issue";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 25F);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(207, 9);
            label2.Name = "label2";
            label2.Size = new Size(636, 59);
            label2.TabIndex = 39;
            label2.Text = "Issue New Driving License";
            // 
            // frmIssueDrivingLicenseForFirstTime
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1051, 688);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtNotes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmIssueDrivingLicenseForFirstTime";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Driving License For First Time";
            Load += frmIssueDrivingLicenseForFirstTime_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtNotes;
        private Button btnClose;
        private Button btnSave;
        private Label label2;
    }
}