namespace DVLD
{
    partial class frmReplacmentForLost_DamagedLicense
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbLostLicense = new RadioButton();
            rbDamagedLicense = new RadioButton();
            txtNotes = new TextBox();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            lblAppFees = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            lblAppDate = new Label();
            lblCreatedBy = new Label();
            pictureBox12 = new PictureBox();
            label19 = new Label();
            lblReplacedLicenseID = new Label();
            lblOldLicenseID = new Label();
            lblAppID = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            llblShowLicenseInfo = new LinkLabel();
            llblShowLicenseHistory = new LinkLabel();
            btnClose = new Button();
            label1 = new Label();
            ctrlLocalLicenseInfoWithFilter1 = new ctrlLocalLicenseInfoWithFilter();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lblAppFees);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblAppDate);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(pictureBox12);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(lblReplacedLicenseID);
            groupBox1.Controls.Add(lblOldLicenseID);
            groupBox1.Controls.Add(lblAppID);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Arial Black", 9F);
            groupBox1.Location = new Point(16, 539);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 289);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbLostLicense);
            groupBox2.Controls.Add(rbDamagedLicense);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI Black", 9F);
            groupBox2.Location = new Point(772, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 115);
            groupBox2.TabIndex = 69;
            groupBox2.TabStop = false;
            groupBox2.Text = "Replacment For";
            // 
            // rbLostLicense
            // 
            rbLostLicense.AutoSize = true;
            rbLostLicense.Location = new Point(20, 67);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.Size = new Size(117, 24);
            rbLostLicense.TabIndex = 1;
            rbLostLicense.TabStop = true;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.UseVisualStyleBackColor = true;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Checked = true;
            rbDamagedLicense.Location = new Point(20, 27);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(155, 24);
            rbDamagedLicense.TabIndex = 0;
            rbDamagedLicense.TabStop = true;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(172, 179);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(594, 104);
            txtNotes.TabIndex = 68;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.writing_language;
            pictureBox3.Location = new Point(117, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 67;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 10F);
            label12.Location = new Point(29, 179);
            label12.Name = "label12";
            label12.Size = new Size(82, 24);
            label12.TabIndex = 66;
            label12.Text = "Notes : ";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Arial Black", 10F);
            lblAppFees.Location = new Point(243, 122);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(68, 24);
            lblAppFees.TabIndex = 65;
            lblAppFees.Text = "[$$$$]";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(199, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 10F);
            label5.Location = new Point(23, 122);
            label5.Name = "label5";
            label5.Size = new Size(181, 24);
            label5.TabIndex = 63;
            label5.Text = "Application Fees : ";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Arial Black", 10F);
            lblAppDate.Location = new Point(243, 79);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(94, 24);
            lblAppDate.TabIndex = 59;
            lblAppDate.Text = "[??/??/??]";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Arial Black", 10F);
            lblCreatedBy.Location = new Point(763, 124);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(64, 24);
            lblCreatedBy.TabIndex = 58;
            lblCreatedBy.Text = "[????]";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.administrator;
            pictureBox12.Location = new Point(708, 124);
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
            label19.Location = new Point(576, 124);
            label19.Name = "label19";
            label19.Size = new Size(130, 24);
            label19.TabIndex = 54;
            label19.Text = "Created By : ";
            // 
            // lblReplacedLicenseID
            // 
            lblReplacedLicenseID.AutoSize = true;
            lblReplacedLicenseID.Font = new Font("Arial Black", 10F);
            lblReplacedLicenseID.Location = new Point(765, 38);
            lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            lblReplacedLicenseID.Size = new Size(64, 24);
            lblReplacedLicenseID.TabIndex = 48;
            lblReplacedLicenseID.Text = "[????]";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.Font = new Font("Arial Black", 10F);
            lblOldLicenseID.Location = new Point(763, 81);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(64, 24);
            lblOldLicenseID.TabIndex = 46;
            lblOldLicenseID.Text = "[????]";
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Arial Black", 10F);
            lblAppID.Location = new Point(243, 36);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(64, 24);
            lblAppID.TabIndex = 37;
            lblAppID.Text = "[????]";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.calendar;
            pictureBox9.Location = new Point(198, 79);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 45;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.id;
            pictureBox8.Location = new Point(711, 38);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 44;
            pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.id;
            pictureBox6.Location = new Point(710, 81);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.track_information;
            pictureBox5.Location = new Point(198, 36);
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
            label11.Location = new Point(23, 79);
            label11.Name = "label11";
            label11.Size = new Size(182, 24);
            label11.TabIndex = 41;
            label11.Text = "Application Date : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 10F);
            label10.Location = new Point(490, 38);
            label10.Name = "label10";
            label10.Size = new Size(216, 24);
            label10.TabIndex = 40;
            label10.Text = "Replaced License ID : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 10F);
            label8.Location = new Point(543, 81);
            label8.Name = "label8";
            label8.Size = new Size(162, 24);
            label8.TabIndex = 38;
            label8.Text = "Old License ID : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 10F);
            label7.Location = new Point(4, 36);
            label7.Name = "label7";
            label7.Size = new Size(200, 24);
            label7.TabIndex = 34;
            label7.Text = "L/R. Application ID : ";
            // 
            // llblShowLicenseInfo
            // 
            llblShowLicenseInfo.AutoSize = true;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseInfo.Font = new Font("Arial Black", 10F);
            llblShowLicenseInfo.LinkColor = Color.FromArgb(0, 0, 64);
            llblShowLicenseInfo.Location = new Point(230, 831);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(123, 24);
            llblShowLicenseInfo.TabIndex = 62;
            llblShowLicenseInfo.TabStop = true;
            llblShowLicenseInfo.Text = "License Info";
            llblShowLicenseInfo.LinkClicked += llblShowLicenseInfo_LinkClicked;
            // 
            // llblShowLicenseHistory
            // 
            llblShowLicenseHistory.AutoSize = true;
            llblShowLicenseHistory.Enabled = false;
            llblShowLicenseHistory.Font = new Font("Arial Black", 9F);
            llblShowLicenseHistory.LinkColor = Color.FromArgb(0, 0, 64);
            llblShowLicenseHistory.Location = new Point(16, 831);
            llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            llblShowLicenseHistory.Size = new Size(204, 22);
            llblShowLicenseHistory.TabIndex = 61;
            llblShowLicenseHistory.TabStop = true;
            llblShowLicenseHistory.Text = "Driver Licenses History";
            llblShowLicenseHistory.LinkClicked += llblShowLicenseHistory_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(806, 833);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 50);
            btnClose.TabIndex = 60;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(322, 6);
            label1.Name = "label1";
            label1.Size = new Size(419, 59);
            label1.TabIndex = 59;
            label1.Text = "Replace License ";
            // 
            // ctrlLocalLicenseInfoWithFilter1
            // 
            ctrlLocalLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlLocalLicenseInfoWithFilter1.Font = new Font("Arial Black", 12F);
            ctrlLocalLicenseInfoWithFilter1.Location = new Point(5, 57);
            ctrlLocalLicenseInfoWithFilter1.Margin = new Padding(6, 4, 6, 4);
            ctrlLocalLicenseInfoWithFilter1.Name = "ctrlLocalLicenseInfoWithFilter1";
            ctrlLocalLicenseInfoWithFilter1.Size = new Size(1053, 492);
            ctrlLocalLicenseInfoWithFilter1.TabIndex = 58;
            ctrlLocalLicenseInfoWithFilter1.OnLicenseSelected += ctrlLocalLicenseInfoWithFilter1_OnLicenseSelected;
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
            btnSave.Location = new Point(934, 833);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 50);
            btnSave.TabIndex = 64;
            btnSave.Text = "Issue";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmReplacmentForLost_DamagedLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1062, 891);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(llblShowLicenseInfo);
            Controls.Add(llblShowLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlLocalLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmReplacmentForLost_DamagedLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Replacment For Lost/Damaged License";
            Load += frmReplacmentForLost_DamagedLicense_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNotes;
        private PictureBox pictureBox3;
        private Label label12;
        private Label lblAppFees;
        private PictureBox pictureBox2;
        private Label label5;
        private Label lblAppDate;
        private Label lblCreatedBy;
        private PictureBox pictureBox12;
        private Label label19;
        private Label lblReplacedLicenseID;
        private Label lblOldLicenseID;
        private Label lblAppID;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private LinkLabel llblShowLicenseInfo;
        private LinkLabel llblShowLicenseHistory;
        private Button btnClose;
        private Label label1;
        private ctrlLocalLicenseInfoWithFilter ctrlLocalLicenseInfoWithFilter1;
        private GroupBox groupBox2;
        private RadioButton rbLostLicense;
        private RadioButton rbDamagedLicense;
        private Button btnSave;
    }
}