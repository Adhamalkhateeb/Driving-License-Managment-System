namespace DVLD
{
    partial class ctrlScheduleTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbSchedualTest = new GroupBox();
            AppointmentDate = new DateTimePicker();
            pictureBox10 = new PictureBox();
            label12 = new Label();
            lblLockedTest = new Label();
            lblFees = new Label();
            lblTrial = new Label();
            lblName = new Label();
            lblDrivingLicenseClass = new Label();
            lblDrivingLicenseAppID = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTestTitle = new Label();
            pbTitleImage = new PictureBox();
            gbRetakeTest = new GroupBox();
            lblTotalFees = new Label();
            lblRetakeAppID = new Label();
            lblRetakeAppFees = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            btnSave = new Button();
            gbSchedualTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).BeginInit();
            gbRetakeTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbSchedualTest
            // 
            gbSchedualTest.Controls.Add(AppointmentDate);
            gbSchedualTest.Controls.Add(pictureBox10);
            gbSchedualTest.Controls.Add(label12);
            gbSchedualTest.Controls.Add(lblLockedTest);
            gbSchedualTest.Controls.Add(lblFees);
            gbSchedualTest.Controls.Add(lblTrial);
            gbSchedualTest.Controls.Add(lblName);
            gbSchedualTest.Controls.Add(lblDrivingLicenseClass);
            gbSchedualTest.Controls.Add(lblDrivingLicenseAppID);
            gbSchedualTest.Controls.Add(pictureBox6);
            gbSchedualTest.Controls.Add(pictureBox5);
            gbSchedualTest.Controls.Add(pictureBox4);
            gbSchedualTest.Controls.Add(pictureBox3);
            gbSchedualTest.Controls.Add(pictureBox2);
            gbSchedualTest.Controls.Add(label6);
            gbSchedualTest.Controls.Add(label5);
            gbSchedualTest.Controls.Add(label4);
            gbSchedualTest.Controls.Add(label3);
            gbSchedualTest.Controls.Add(label2);
            gbSchedualTest.Controls.Add(lblTestTitle);
            gbSchedualTest.Controls.Add(pbTitleImage);
            gbSchedualTest.Location = new Point(5, 4);
            gbSchedualTest.Margin = new Padding(5, 4, 5, 4);
            gbSchedualTest.Name = "gbSchedualTest";
            gbSchedualTest.Padding = new Padding(5, 4, 5, 4);
            gbSchedualTest.Size = new Size(701, 533);
            gbSchedualTest.TabIndex = 0;
            gbSchedualTest.TabStop = false;
            gbSchedualTest.Text = "Vision Test";
            // 
            // AppointmentDate
            // 
            AppointmentDate.Format = DateTimePickerFormat.Custom;
            AppointmentDate.Location = new Point(305, 434);
            AppointmentDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.Size = new Size(261, 36);
            AppointmentDate.TabIndex = 0;
            AppointmentDate.Value = new DateTime(2025, 2, 19, 4, 4, 52, 0);
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.calendar_week;
            pictureBox10.Location = new Point(239, 434);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(41, 34);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 48;
            pictureBox10.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 434);
            label12.Name = "label12";
            label12.Size = new Size(223, 28);
            label12.TabIndex = 47;
            label12.Text = "Appointment Date :";
            // 
            // lblLockedTest
            // 
            lblLockedTest.AutoSize = true;
            lblLockedTest.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLockedTest.ForeColor = Color.Red;
            lblLockedTest.Location = new Point(100, 187);
            lblLockedTest.Name = "lblLockedTest";
            lblLockedTest.Size = new Size(501, 24);
            lblLockedTest.TabIndex = 46;
            lblLockedTest.Text = "Person Already Sat For the test, Appointmetn Locked";
            lblLockedTest.Visible = false;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Location = new Point(305, 478);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(76, 28);
            lblFees.TabIndex = 45;
            lblFees.Text = "[????]";
            // 
            // lblTrial
            // 
            lblTrial.AutoSize = true;
            lblTrial.Location = new Point(304, 384);
            lblTrial.Name = "lblTrial";
            lblTrial.Size = new Size(76, 28);
            lblTrial.TabIndex = 44;
            lblTrial.Text = "[????]";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(304, 335);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 28);
            lblName.TabIndex = 43;
            lblName.Text = "[????]";
            // 
            // lblDrivingLicenseClass
            // 
            lblDrivingLicenseClass.AutoSize = true;
            lblDrivingLicenseClass.Location = new Point(304, 286);
            lblDrivingLicenseClass.Name = "lblDrivingLicenseClass";
            lblDrivingLicenseClass.Size = new Size(76, 28);
            lblDrivingLicenseClass.TabIndex = 42;
            lblDrivingLicenseClass.Text = "[????]";
            // 
            // lblDrivingLicenseAppID
            // 
            lblDrivingLicenseAppID.AutoSize = true;
            lblDrivingLicenseAppID.Location = new Point(304, 237);
            lblDrivingLicenseAppID.Name = "lblDrivingLicenseAppID";
            lblDrivingLicenseAppID.Size = new Size(76, 28);
            lblDrivingLicenseAppID.TabIndex = 41;
            lblDrivingLicenseAppID.Text = "[????]";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.money_32;
            pictureBox6.Location = new Point(239, 478);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.success;
            pictureBox5.Location = new Point(238, 384);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(238, 335);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.id__6_;
            pictureBox3.Location = new Point(238, 286);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.id__2_;
            pictureBox2.Location = new Point(238, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 477);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 7;
            label6.Text = "Fees :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 381);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 6;
            label5.Text = "Trial :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 333);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 5;
            label4.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 285);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 4;
            label3.Text = "D.L Class:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 237);
            label2.Name = "label2";
            label2.Size = new Size(224, 28);
            label2.TabIndex = 3;
            label2.Text = "D.L Application ID :";
            // 
            // lblTestTitle
            // 
            lblTestTitle.AutoSize = true;
            lblTestTitle.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTitle.ForeColor = Color.Brown;
            lblTestTitle.Location = new Point(195, 135);
            lblTestTitle.Name = "lblTestTitle";
            lblTestTitle.Size = new Size(311, 52);
            lblTestTitle.TabIndex = 2;
            lblTestTitle.Text = "Schedual Test";
            lblTestTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbTitleImage
            // 
            pbTitleImage.Image = Properties.Resources.driving_test_512;
            pbTitleImage.Location = new Point(231, 0);
            pbTitleImage.Name = "pbTitleImage";
            pbTitleImage.Size = new Size(239, 140);
            pbTitleImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitleImage.TabIndex = 1;
            pbTitleImage.TabStop = false;
            // 
            // gbRetakeTest
            // 
            gbRetakeTest.Controls.Add(lblTotalFees);
            gbRetakeTest.Controls.Add(lblRetakeAppID);
            gbRetakeTest.Controls.Add(lblRetakeAppFees);
            gbRetakeTest.Controls.Add(pictureBox9);
            gbRetakeTest.Controls.Add(pictureBox8);
            gbRetakeTest.Controls.Add(pictureBox1);
            gbRetakeTest.Controls.Add(label9);
            gbRetakeTest.Controls.Add(label8);
            gbRetakeTest.Controls.Add(label1);
            gbRetakeTest.Font = new Font("Bodoni MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRetakeTest.Location = new Point(5, 556);
            gbRetakeTest.Name = "gbRetakeTest";
            gbRetakeTest.Size = new Size(701, 143);
            gbRetakeTest.TabIndex = 9;
            gbRetakeTest.TabStop = false;
            gbRetakeTest.Text = "Retake Test Info";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.Location = new Point(602, 48);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(76, 28);
            lblTotalFees.TabIndex = 44;
            lblTotalFees.Text = "[????]";
            // 
            // lblRetakeAppID
            // 
            lblRetakeAppID.AutoSize = true;
            lblRetakeAppID.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetakeAppID.Location = new Point(289, 96);
            lblRetakeAppID.Name = "lblRetakeAppID";
            lblRetakeAppID.Size = new Size(51, 28);
            lblRetakeAppID.TabIndex = 43;
            lblRetakeAppID.Text = "N/A";
            // 
            // lblRetakeAppFees
            // 
            lblRetakeAppFees.AutoSize = true;
            lblRetakeAppFees.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetakeAppFees.Location = new Point(289, 48);
            lblRetakeAppFees.Name = "lblRetakeAppFees";
            lblRetakeAppFees.Size = new Size(58, 28);
            lblRetakeAppFees.TabIndex = 42;
            lblRetakeAppFees.Text = "0.00";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.money_32___2;
            pictureBox9.Location = new Point(544, 42);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(41, 34);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 41;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.id__2_;
            pictureBox8.Location = new Point(226, 96);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 34);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 41;
            pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money_32;
            pictureBox1.Location = new Point(226, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(400, 42);
            label9.Name = "label9";
            label9.Size = new Size(138, 28);
            label9.TabIndex = 11;
            label9.Text = "Total Fees :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 96);
            label8.Name = "label8";
            label8.Size = new Size(176, 28);
            label8.TabIndex = 10;
            label8.Text = "R.Test App ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 9;
            label1.Text = "R.App Fees :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Black", 10F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(588, 712);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 44);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // ctrlScheduleTest
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(gbRetakeTest);
            Controls.Add(gbSchedualTest);
            Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ctrlScheduleTest";
            Size = new Size(716, 764);
            gbSchedualTest.ResumeLayout(false);
            gbSchedualTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTitleImage).EndInit();
            gbRetakeTest.ResumeLayout(false);
            gbRetakeTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSchedualTest;
        private PictureBox pbTitleImage;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTestTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label lblFees;
        private Label lblTrial;
        private Label lblName;
        private Label lblDrivingLicenseClass;
        private Label lblDrivingLicenseAppID;
        private DateTimePicker AppointmentDate;
        private PictureBox pictureBox10;
        private Label label12;
        private Label lblLockedTest;
        private GroupBox gbRetakeTest;
        private Label lblTotalFees;
        private Label lblRetakeAppID;
        private Label lblRetakeAppFees;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Label label1;
        private Button btnSave;
    }
}
