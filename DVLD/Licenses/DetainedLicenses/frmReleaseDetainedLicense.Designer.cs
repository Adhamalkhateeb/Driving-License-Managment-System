namespace DVLD
{
    partial class frmReleaseDetainedLicense
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
            txtNotes = new TextBox();
            lblTotalFees = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            lblAppFees = new Label();
            pictureBox2 = new PictureBox();
            l = new Label();
            lblFineFees = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblCreatedBy = new Label();
            lblDetainDate = new Label();
            pictureBox12 = new PictureBox();
            label19 = new Label();
            lblLocalLicenseID = new Label();
            label8 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox6 = new PictureBox();
            label18 = new Label();
            lblDetainID = new Label();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            label7 = new Label();
            llblShowLicenseInfo = new LinkLabel();
            llblShowLicenseHistory = new LinkLabel();
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            ctrlLocalLicenseInfoWithFilter1 = new ctrlLocalLicenseInfoWithFilter();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(lblTotalFees);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblAppFees);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(l);
            groupBox1.Controls.Add(lblFineFees);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(lblDetainDate);
            groupBox1.Controls.Add(pictureBox12);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(lblLocalLicenseID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pictureBox11);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblDetainID);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Arial Black", 9F);
            groupBox1.Location = new Point(22, 571);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 249);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detain Info";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Enabled = false;
            txtNotes.Location = new Point(171, 167);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(411, 66);
            txtNotes.TabIndex = 71;
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Arial Black", 10F);
            lblTotalFees.Location = new Point(768, 167);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(68, 24);
            lblTotalFees.TabIndex = 70;
            lblTotalFees.Text = "[$$$$]";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32___2;
            pictureBox3.Location = new Point(710, 167);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 69;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 10F);
            label6.Location = new Point(588, 167);
            label6.Name = "label6";
            label6.Size = new Size(123, 24);
            label6.TabIndex = 68;
            label6.Text = "Total Fees : ";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Arial Black", 10F);
            lblAppFees.Location = new Point(255, 128);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(68, 24);
            lblAppFees.TabIndex = 66;
            lblAppFees.Text = "[$$$$]";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(215, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Arial Black", 10F);
            l.Location = new Point(35, 126);
            l.Name = "l";
            l.Size = new Size(181, 24);
            l.TabIndex = 64;
            l.Text = "Application Fees : ";
            // 
            // lblFineFees
            // 
            lblFineFees.AutoSize = true;
            lblFineFees.Font = new Font("Arial Black", 10F);
            lblFineFees.Location = new Point(768, 126);
            lblFineFees.Name = "lblFineFees";
            lblFineFees.Size = new Size(68, 24);
            lblFineFees.TabIndex = 63;
            lblFineFees.Text = "[$$$$]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.writing_language;
            pictureBox1.Location = new Point(118, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 10F);
            label2.Location = new Point(41, 167);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 60;
            label2.Text = "Notes : ";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Arial Black", 10F);
            lblCreatedBy.Location = new Point(768, 80);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(64, 24);
            lblCreatedBy.TabIndex = 58;
            lblCreatedBy.Text = "[????]";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Arial Black", 10F);
            lblDetainDate.Location = new Point(255, 80);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(94, 24);
            lblDetainDate.TabIndex = 57;
            lblDetainDate.Text = "[??/??/??]";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.administrator;
            pictureBox12.Location = new Point(710, 82);
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
            label19.Location = new Point(581, 80);
            label19.Name = "label19";
            label19.Size = new Size(130, 24);
            label19.TabIndex = 54;
            label19.Text = "Created By : ";
            // 
            // lblLocalLicenseID
            // 
            lblLocalLicenseID.AutoSize = true;
            lblLocalLicenseID.Font = new Font("Arial Black", 10F);
            lblLocalLicenseID.Location = new Point(768, 38);
            lblLocalLicenseID.Name = "lblLocalLicenseID";
            lblLocalLicenseID.Size = new Size(64, 24);
            lblLocalLicenseID.TabIndex = 46;
            lblLocalLicenseID.Text = "[????]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 10F);
            label8.Location = new Point(583, 38);
            label8.Name = "label8";
            label8.Size = new Size(125, 24);
            label8.TabIndex = 38;
            label8.Text = "License ID : ";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.calendar_week;
            pictureBox11.Location = new Point(211, 82);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(38, 26);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 53;
            pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.id;
            pictureBox6.Location = new Point(710, 38);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Black", 10F);
            label18.Location = new Point(79, 80);
            label18.Name = "label18";
            label18.Size = new Size(137, 24);
            label18.TabIndex = 52;
            label18.Text = "Detain Date : ";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Arial Black", 10F);
            lblDetainID.Location = new Point(255, 38);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(64, 24);
            lblDetainID.TabIndex = 37;
            lblDetainID.Text = "[????]";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.money_32;
            pictureBox7.Location = new Point(710, 126);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 26);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 43;
            pictureBox7.TabStop = false;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 10F);
            label9.Location = new Point(596, 126);
            label9.Name = "label9";
            label9.Size = new Size(115, 24);
            label9.TabIndex = 39;
            label9.Text = "Fine Fees : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 10F);
            label7.Location = new Point(102, 38);
            label7.Name = "label7";
            label7.Size = new Size(114, 24);
            label7.TabIndex = 34;
            label7.Text = "Detain ID : ";
            // 
            // llblShowLicenseInfo
            // 
            llblShowLicenseInfo.AutoSize = true;
            llblShowLicenseInfo.Enabled = false;
            llblShowLicenseInfo.Font = new Font("Arial Black", 9F);
            llblShowLicenseInfo.LinkColor = Color.FromArgb(0, 0, 64);
            llblShowLicenseInfo.Location = new Point(232, 827);
            llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            llblShowLicenseInfo.Size = new Size(111, 22);
            llblShowLicenseInfo.TabIndex = 56;
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
            llblShowLicenseHistory.Location = new Point(22, 827);
            llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            llblShowLicenseHistory.Size = new Size(204, 22);
            llblShowLicenseHistory.TabIndex = 55;
            llblShowLicenseHistory.TabStop = true;
            llblShowLicenseHistory.Text = "Driver Licenses History";
            llblShowLicenseHistory.LinkClicked += llblShowLicenseHistory_LinkClicked;
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
            btnSave.Location = new Point(929, 837);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 50);
            btnSave.TabIndex = 54;
            btnSave.Text = "Release";
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
            btnClose.Location = new Point(790, 837);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 50);
            btnClose.TabIndex = 53;
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
            label1.Location = new Point(226, 20);
            label1.Name = "label1";
            label1.Size = new Size(623, 59);
            label1.TabIndex = 52;
            label1.Text = "Release Detained License";
            // 
            // ctrlLocalLicenseInfoWithFilter1
            // 
            ctrlLocalLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlLocalLicenseInfoWithFilter1.Font = new Font("Arial Black", 12F);
            ctrlLocalLicenseInfoWithFilter1.Location = new Point(11, 83);
            ctrlLocalLicenseInfoWithFilter1.Margin = new Padding(6, 4, 6, 4);
            ctrlLocalLicenseInfoWithFilter1.Name = "ctrlLocalLicenseInfoWithFilter1";
            ctrlLocalLicenseInfoWithFilter1.Size = new Size(1053, 481);
            ctrlLocalLicenseInfoWithFilter1.TabIndex = 51;
            ctrlLocalLicenseInfoWithFilter1.OnLicenseSelected += ctrlLocalLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // frmReleaseDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmReleaseDetainedLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Release Detained License";
            Load += frmReleaseDetainedLicense_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblCreatedBy;
        private Label lblDetainDate;
        private PictureBox pictureBox12;
        private Label label19;
        private Label lblLocalLicenseID;
        private Label label8;
        private PictureBox pictureBox11;
        private PictureBox pictureBox6;
        private Label label18;
        private Label lblDetainID;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private Label label9;
        private Label label7;
        private LinkLabel llblShowLicenseInfo;
        private LinkLabel llblShowLicenseHistory;
        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private ctrlLocalLicenseInfoWithFilter ctrlLocalLicenseInfoWithFilter1;
        private Label lblAppFees;
        private PictureBox pictureBox2;
        private Label l;
        private Label lblFineFees;
        private Label lblTotalFees;
        private PictureBox pictureBox3;
        private Label label6;
        private TextBox txtNotes;
    }
}