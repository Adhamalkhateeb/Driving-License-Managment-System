namespace DVLD
{
    partial class frmAddNewInternationalLicenseApplication
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
            ctrlLocalLicenseInfoWithFilter1 = new ctrlLocalLicenseInfoWithFilter();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            llblShowLicenseHistory = new LinkLabel();
            llblShowLicenseInfo = new LinkLabel();
            groupBox1 = new GroupBox();
            lblAppDate = new Label();
            lblCreatedBy = new Label();
            lblIssueDate = new Label();
            lblExpirationDate = new Label();
            pictureBox12 = new PictureBox();
            label19 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            label17 = new Label();
            lblInternationalLIcenseID = new Label();
            label18 = new Label();
            lblFees = new Label();
            lblLocalLicenseID = new Label();
            lblAppID = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // ctrlLocalLicenseInfoWithFilter1
            // 
            ctrlLocalLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlLocalLicenseInfoWithFilter1.Font = new Font("Arial Black", 12F);
            ctrlLocalLicenseInfoWithFilter1.Location = new Point(15, 83);
            ctrlLocalLicenseInfoWithFilter1.Margin = new Padding(6, 4, 6, 4);
            ctrlLocalLicenseInfoWithFilter1.Name = "ctrlLocalLicenseInfoWithFilter1";
            ctrlLocalLicenseInfoWithFilter1.Size = new Size(1053, 492);
            ctrlLocalLicenseInfoWithFilter1.TabIndex = 0;
            ctrlLocalLicenseInfoWithFilter1.OnLicenseSelected += ctrlLocalLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(751, 59);
            label1.TabIndex = 3;
            label1.Text = "Add New International License ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Black", 10F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(933, 837);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 50);
            btnSave.TabIndex = 40;
            btnSave.Text = "Issue";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(794, 837);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 50);
            btnClose.TabIndex = 39;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // llblShowLicenseHistory
            // 
            llblShowLicenseHistory.AutoSize = true;
            llblShowLicenseHistory.Enabled = false;
            llblShowLicenseHistory.LinkColor = Color.FromArgb(0, 0, 64);
            llblShowLicenseHistory.Location = new Point(33, 814);
            llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            llblShowLicenseHistory.Size = new Size(227, 24);
            llblShowLicenseHistory.TabIndex = 41;
            llblShowLicenseHistory.TabStop = true;
            llblShowLicenseHistory.Text = "Driver Licenses History";
            llblShowLicenseHistory.LinkClicked += llblShowLicenseHistory_LinkClicked;
            // 
            // llblShowLicenseInfo
            // 
            llblShowLicenseInfo.AutoSize = true;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseInfo.Font = new Font("Arial Black", 10F);
            llblShowLicenseInfo.LinkColor = Color.FromArgb(0, 0, 64);
            llblShowLicenseInfo.Location = new Point(266, 814);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(123, 24);
            llblShowLicenseInfo.TabIndex = 42;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAppDate);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(lblExpirationDate);
            groupBox1.Controls.Add(pictureBox12);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(pictureBox10);
            groupBox1.Controls.Add(pictureBox11);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(lblInternationalLIcenseID);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblFees);
            groupBox1.Controls.Add(lblLocalLicenseID);
            groupBox1.Controls.Add(lblAppID);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Arial Black", 9F);
            groupBox1.Location = new Point(26, 571);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 227);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Arial Black", 10F);
            lblAppDate.Location = new Point(269, 172);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(94, 24);
            lblAppDate.TabIndex = 59;
            lblAppDate.Text = "[??/??/??]";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Arial Black", 10F);
            lblCreatedBy.Location = new Point(765, 168);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(64, 24);
            lblCreatedBy.TabIndex = 58;
            lblCreatedBy.Text = "[????]";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Arial Black", 10F);
            lblIssueDate.Location = new Point(765, 80);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(94, 24);
            lblIssueDate.TabIndex = 57;
            lblIssueDate.Text = "[??/??/??]";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Arial Black", 10F);
            lblExpirationDate.Location = new Point(765, 122);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(94, 24);
            lblExpirationDate.TabIndex = 56;
            lblExpirationDate.Text = "[??/??/??]";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.administrator;
            pictureBox12.Location = new Point(714, 168);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(38, 26);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 55;
            pictureBox12.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Black", 10F);
            label19.Location = new Point(578, 168);
            label19.Name = "label19";
            label19.Size = new Size(130, 24);
            label19.TabIndex = 54;
            label19.Text = "Created By : ";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.calendar_week;
            pictureBox10.Location = new Point(714, 122);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(38, 26);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 51;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.calendar_week;
            pictureBox11.Location = new Point(714, 82);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(38, 26);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 53;
            pictureBox11.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Black", 10F);
            label17.Location = new Point(536, 122);
            label17.Name = "label17";
            label17.Size = new Size(172, 24);
            label17.TabIndex = 50;
            label17.Text = "Expiration Date : ";
            // 
            // lblInternationalLIcenseID
            // 
            lblInternationalLIcenseID.AutoSize = true;
            lblInternationalLIcenseID.Font = new Font("Arial Black", 10F);
            lblInternationalLIcenseID.Location = new Point(765, 38);
            lblInternationalLIcenseID.Name = "lblInternationalLIcenseID";
            lblInternationalLIcenseID.Size = new Size(64, 24);
            lblInternationalLIcenseID.TabIndex = 48;
            lblInternationalLIcenseID.Text = "[????]";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Black", 10F);
            label18.Location = new Point(582, 80);
            label18.Name = "label18";
            label18.Size = new Size(126, 24);
            label18.TabIndex = 52;
            label18.Text = "Issue Date : ";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Arial Black", 10F);
            lblFees.Location = new Point(269, 124);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(68, 24);
            lblFees.TabIndex = 47;
            lblFees.Text = "[$$$$]";
            // 
            // lblLocalLicenseID
            // 
            lblLocalLicenseID.AutoSize = true;
            lblLocalLicenseID.Font = new Font("Arial Black", 10F);
            lblLocalLicenseID.Location = new Point(269, 80);
            lblLocalLicenseID.Name = "lblLocalLicenseID";
            lblLocalLicenseID.Size = new Size(64, 24);
            lblLocalLicenseID.TabIndex = 46;
            lblLocalLicenseID.Text = "[????]";
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Arial Black", 10F);
            lblAppID.Location = new Point(269, 38);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(64, 24);
            lblAppID.TabIndex = 37;
            lblAppID.Text = "[????]";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.calendar;
            pictureBox9.Location = new Point(211, 170);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 45;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.world;
            pictureBox8.Location = new Point(711, 38);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 44;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.money_32;
            pictureBox7.Location = new Point(211, 124);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 43;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.id;
            pictureBox6.Location = new Point(211, 80);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.track_information;
            pictureBox5.Location = new Point(211, 36);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 10F);
            label11.Location = new Point(23, 172);
            label11.Name = "label11";
            label11.Size = new Size(182, 24);
            label11.TabIndex = 41;
            label11.Text = "Application Date : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 10F);
            label10.Location = new Point(456, 38);
            label10.Name = "label10";
            label10.Size = new Size(252, 24);
            label10.TabIndex = 40;
            label10.Text = "International License ID : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 10F);
            label9.Location = new Point(135, 124);
            label9.Name = "label9";
            label9.Size = new Size(70, 24);
            label9.TabIndex = 39;
            label9.Text = "Fees : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 10F);
            label8.Location = new Point(24, 80);
            label8.Name = "label8";
            label8.Size = new Size(181, 24);
            label8.TabIndex = 38;
            label8.Text = "Local License ID : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 10F);
            label7.Location = new Point(16, 36);
            label7.Name = "label7";
            label7.Size = new Size(189, 24);
            label7.TabIndex = 34;
            label7.Text = "I.L Application ID : ";
            // 
            // frmAddNewInternationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1074, 896);
            Controls.Add(groupBox1);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlLocalLicenseInfoWithFilter1);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmAddNewInternationalLicenseApplication";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New International License Application";
            Load += frmAddNewInternationalLicenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlLocalLicenseInfoWithFilter ctrlLocalLicenseInfoWithFilter1;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private LinkLabel llblShowLicenseHistory;
        private LinkLabel llblShowLicenseInfo;
        private GroupBox groupBox1;
        private Label lblCreatedBy;
        private Label lblIssueDate;
        private Label lblExpirationDate;
        private PictureBox pictureBox12;
        private Label label19;
        private PictureBox pictureBox11;
        private Label label18;
        private PictureBox pictureBox10;
        private Label label17;
        private Label lblInternationalLIcenseID;
        private Label lblFees;
        private Label lblLocalLicenseID;
        private Label lblAppID;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblAppDate;
    }
}