namespace DVLD
{
    partial class frmNew_EditLocalDrivingLicense
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            ctrlPersonCardWithFilter2 = new ctrlPersonCardWithFilter();
            btnSave = new Button();
            btnClose = new Button();
            tabControl1 = new TabControl();
            tabPersonalInfo = new TabPage();
            btnNext = new Button();
            tabApplicationInfo = new TabPage();
            cbLicenseClass = new ComboBox();
            lblCreatedBy = new Label();
            lblAppFees = new Label();
            lblAppDate = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            pbConfirmPassword = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAppID = new Label();
            pictureBox1 = new PictureBox();
            label = new Label();
            label4 = new Label();
            label3 = new Label();
            ctrlPersonCard1 = new ctrlPersonCard();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            tabApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 23F);
            lblTitle.ForeColor = Color.Brown;
            lblTitle.Location = new Point(118, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(846, 55);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "New Local Driving License Application";
            // 
            // ctrlPersonCardWithFilter2
            // 
            ctrlPersonCardWithFilter2.FilterEnabled = true;
            ctrlPersonCardWithFilter2.Font = new Font("Segoe UI", 6F);
            ctrlPersonCardWithFilter2.Location = new Point(2, 2);
            ctrlPersonCardWithFilter2.Margin = new Padding(2);
            ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            ctrlPersonCardWithFilter2.ShowAddPerson = true;
            ctrlPersonCardWithFilter2.Size = new Size(1071, 464);
            ctrlPersonCardWithFilter2.TabIndex = 0;
            ctrlPersonCardWithFilter2.OnPersonSelected += ctrlPersonCardWithFilter2_OnPersonSelected;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Black", 12F);
            btnSave.Image = Properties.Resources.favorite_15111499;
            btnSave.Location = new Point(907, 726);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 73);
            btnSave.TabIndex = 7;
            btnSave.Text = " Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 12F);
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(722, 726);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(165, 73);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPersonalInfo);
            tabControl1.Controls.Add(tabApplicationInfo);
            tabControl1.Location = new Point(12, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1063, 601);
            tabControl1.TabIndex = 5;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.Controls.Add(ctrlPersonCardWithFilter2);
            tabPersonalInfo.Controls.Add(btnNext);
            tabPersonalInfo.Location = new Point(4, 37);
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.Padding = new Padding(3);
            tabPersonalInfo.Size = new Size(1055, 560);
            tabPersonalInfo.TabIndex = 0;
            tabPersonalInfo.Text = "Personal info.";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 2;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Arial Black", 14F);
            btnNext.Image = Properties.Resources.next;
            btnNext.Location = new Point(877, 471);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(169, 73);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // tabApplicationInfo
            // 
            tabApplicationInfo.BackColor = Color.White;
            tabApplicationInfo.BackgroundImageLayout = ImageLayout.None;
            tabApplicationInfo.Controls.Add(cbLicenseClass);
            tabApplicationInfo.Controls.Add(lblCreatedBy);
            tabApplicationInfo.Controls.Add(lblAppFees);
            tabApplicationInfo.Controls.Add(lblAppDate);
            tabApplicationInfo.Controls.Add(pictureBox5);
            tabApplicationInfo.Controls.Add(label7);
            tabApplicationInfo.Controls.Add(pbConfirmPassword);
            tabApplicationInfo.Controls.Add(pictureBox3);
            tabApplicationInfo.Controls.Add(pictureBox2);
            tabApplicationInfo.Controls.Add(lblAppID);
            tabApplicationInfo.Controls.Add(pictureBox1);
            tabApplicationInfo.Controls.Add(label);
            tabApplicationInfo.Controls.Add(label4);
            tabApplicationInfo.Controls.Add(label3);
            tabApplicationInfo.Controls.Add(ctrlPersonCard1);
            tabApplicationInfo.Controls.Add(label2);
            tabApplicationInfo.Location = new Point(4, 29);
            tabApplicationInfo.Name = "tabApplicationInfo";
            tabApplicationInfo.Padding = new Padding(3);
            tabApplicationInfo.Size = new Size(1055, 568);
            tabApplicationInfo.TabIndex = 1;
            tabApplicationInfo.Text = "Application Info.";
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(344, 488);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(550, 36);
            cbLicenseClass.TabIndex = 21;
            cbLicenseClass.Validating += cbLicenseClass_Validating;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Arial Black", 14F);
            lblCreatedBy.Location = new Point(891, 430);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(93, 33);
            lblCreatedBy.TabIndex = 20;
            lblCreatedBy.Text = "[????]";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Arial Black", 14F);
            lblAppFees.Location = new Point(891, 372);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(93, 33);
            lblAppFees.TabIndex = 19;
            lblAppFees.Text = "[????]";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Arial Black", 12F);
            lblAppDate.Location = new Point(344, 435);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(114, 28);
            lblAppDate.TabIndex = 18;
            lblAppDate.Text = "dd/mm/yy";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.calendar_week;
            pictureBox5.Location = new Point(261, 423);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F);
            label7.Location = new Point(30, 429);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 15;
            label7.Text = "Application Date :";
            // 
            // pbConfirmPassword
            // 
            pbConfirmPassword.Image = Properties.Resources.administrator;
            pbConfirmPassword.Location = new Point(825, 427);
            pbConfirmPassword.Name = "pbConfirmPassword";
            pbConfirmPassword.Size = new Size(46, 40);
            pbConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbConfirmPassword.TabIndex = 9;
            pbConfirmPassword.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(825, 370);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.id;
            pictureBox2.Location = new Point(261, 484);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblAppID
            // 
            lblAppID.AutoSize = true;
            lblAppID.Font = new Font("Arial Black", 12F);
            lblAppID.Location = new Point(344, 372);
            lblAppID.Name = "lblAppID";
            lblAppID.Size = new Size(51, 28);
            lblAppID.TabIndex = 6;
            lblAppID.Text = "N/A";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id__2_;
            pictureBox1.Location = new Point(261, 362);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial Black", 12F);
            label.Location = new Point(672, 433);
            label.Name = "label";
            label.Size = new Size(147, 28);
            label.TabIndex = 0;
            label.Text = "Created By :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F);
            label4.Location = new Point(612, 372);
            label4.Name = "label4";
            label4.Size = new Size(207, 28);
            label4.TabIndex = 0;
            label4.Text = "Application Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F);
            label3.Location = new Point(61, 486);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 0;
            label3.Text = "License Class :";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BorderStyle = BorderStyle.FixedSingle;
            ctrlPersonCard1.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(14, 19);
            ctrlPersonCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.ShowUpdatePerson = false;
            ctrlPersonCard1.Size = new Size(1022, 336);
            ctrlPersonCard1.TabIndex = 0;
            ctrlPersonCard1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F);
            label2.Location = new Point(14, 372);
            label2.Name = "label2";
            label2.Size = new Size(224, 28);
            label2.TabIndex = 0;
            label2.Text = "D.L Application ID :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNew_EditLocalDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1083, 808);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmNew_EditLocalDrivingLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Local Driving License";
            Load += frmNewLocalDrivingLicense_Load;
            tabControl1.ResumeLayout(false);
            tabPersonalInfo.ResumeLayout(false);
            tabApplicationInfo.ResumeLayout(false);
            tabApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
        private Button btnSave;
        private Button btnClose;
        private TabControl tabControl1;
        private TabPage tabPersonalInfo;
        private Button btnNext;
        private TabPage tabApplicationInfo;
        private PictureBox pictureBox5;
        private Label label7;
        private PictureBox pbConfirmPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblAppID;
        private PictureBox pictureBox1;
        private Label label;
        private Label label4;
        private Label label3;
        private ctrlPersonCard ctrlPersonCard1;
        private Label label2;
        private Label lblAppDate;
        private ComboBox cbLicenseClass;
        private Label lblCreatedBy;
        private Label lblAppFees;
        private ErrorProvider errorProvider1;
    }
}