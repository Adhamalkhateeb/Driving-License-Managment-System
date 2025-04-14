namespace DVLD
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            msMain = new MenuStrip();
            btnApplication = new ToolStripMenuItem();
            btnDrivingLicenseService = new ToolStripMenuItem();
            btnNewDrivingLicense = new ToolStripMenuItem();
            btnLocalLicense = new ToolStripMenuItem();
            btnInternationalLicense = new ToolStripMenuItem();
            btnRenewDrivingLicense = new ToolStripMenuItem();
            btnReplacmentLostOrDamagedLicense = new ToolStripMenuItem();
            btnReleaseDetainedDrivingLicense = new ToolStripMenuItem();
            btnRetakeTest = new ToolStripMenuItem();
            btnManageApplications = new ToolStripMenuItem();
            btnlocalDriverLicenseApplication = new ToolStripMenuItem();
            btnInternationalDriverLicenseApplication = new ToolStripMenuItem();
            btnDetainLicense = new ToolStripMenuItem();
            btnManagedDetainedLicense = new ToolStripMenuItem();
            btnDetainLicenses = new ToolStripMenuItem();
            btnReleaseDetainLicense = new ToolStripMenuItem();
            btnManageApTypes = new ToolStripMenuItem();
            btnManageTestTypes = new ToolStripMenuItem();
            btnPeople = new ToolStripMenuItem();
            btnDrivers = new ToolStripMenuItem();
            btnusers = new ToolStripMenuItem();
            btnAccountSettings = new ToolStripMenuItem();
            btnCurrentUserInfo = new ToolStripMenuItem();
            btnChangePassword = new ToolStripMenuItem();
            btnSignOut = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.AutoSize = false;
            msMain.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            msMain.ImageScalingSize = new Size(26, 26);
            msMain.Items.AddRange(new ToolStripItem[] { btnApplication, btnPeople, btnDrivers, btnusers, btnAccountSettings });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1898, 105);
            msMain.TabIndex = 3;
            // 
            // btnApplication
            // 
            btnApplication.DropDownItems.AddRange(new ToolStripItem[] { btnDrivingLicenseService, btnManageApplications, btnDetainLicense, btnManageApTypes, btnManageTestTypes });
            btnApplication.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            btnApplication.Image = Properties.Resources.documents;
            btnApplication.ImageScaling = ToolStripItemImageScaling.None;
            btnApplication.Name = "btnApplication";
            btnApplication.Size = new Size(339, 101);
            btnApplication.Text = "Applications";
            btnApplication.Click += btnApplication_Click;
            // 
            // btnDrivingLicenseService
            // 
            btnDrivingLicenseService.DropDownItems.AddRange(new ToolStripItem[] { btnNewDrivingLicense, btnRenewDrivingLicense, btnReplacmentLostOrDamagedLicense, btnReleaseDetainedDrivingLicense, btnRetakeTest });
            btnDrivingLicenseService.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnDrivingLicenseService.Image = Properties.Resources.id;
            btnDrivingLicenseService.ImageScaling = ToolStripItemImageScaling.None;
            btnDrivingLicenseService.Name = "btnDrivingLicenseService";
            btnDrivingLicenseService.Size = new Size(500, 54);
            btnDrivingLicenseService.Text = "Driving License Service";
            // 
            // btnNewDrivingLicense
            // 
            btnNewDrivingLicense.DropDownItems.AddRange(new ToolStripItem[] { btnLocalLicense, btnInternationalLicense });
            btnNewDrivingLicense.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnNewDrivingLicense.Image = Properties.Resources.id_add__3_;
            btnNewDrivingLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnNewDrivingLicense.Name = "btnNewDrivingLicense";
            btnNewDrivingLicense.Size = new Size(535, 54);
            btnNewDrivingLicense.Text = "New Driving License";
            // 
            // btnLocalLicense
            // 
            btnLocalLicense.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnLocalLicense.Image = Properties.Resources.home;
            btnLocalLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnLocalLicense.Name = "btnLocalLicense";
            btnLocalLicense.Size = new Size(322, 54);
            btnLocalLicense.Text = "Local License";
            btnLocalLicense.Click += btnLocalLicense_Click;
            // 
            // btnInternationalLicense
            // 
            btnInternationalLicense.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            btnInternationalLicense.Image = Properties.Resources.world;
            btnInternationalLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnInternationalLicense.Name = "btnInternationalLicense";
            btnInternationalLicense.Size = new Size(322, 54);
            btnInternationalLicense.Text = "International License";
            btnInternationalLicense.Click += btnInternationalLicense_Click;
            // 
            // btnRenewDrivingLicense
            // 
            btnRenewDrivingLicense.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnRenewDrivingLicense.Image = Properties.Resources.id_reload;
            btnRenewDrivingLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnRenewDrivingLicense.Name = "btnRenewDrivingLicense";
            btnRenewDrivingLicense.Size = new Size(535, 54);
            btnRenewDrivingLicense.Text = "Renew Driving License";
            btnRenewDrivingLicense.Click += btnRenewDrivingLicense_Click;
            // 
            // btnReplacmentLostOrDamagedLicense
            // 
            btnReplacmentLostOrDamagedLicense.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnReplacmentLostOrDamagedLicense.Image = Properties.Resources.id_close__3_;
            btnReplacmentLostOrDamagedLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnReplacmentLostOrDamagedLicense.Name = "btnReplacmentLostOrDamagedLicense";
            btnReplacmentLostOrDamagedLicense.Size = new Size(535, 54);
            btnReplacmentLostOrDamagedLicense.Text = "Replacment Lost or Damaged license";
            btnReplacmentLostOrDamagedLicense.Click += btnReplacmentLostOrDamagedLicense_Click;
            // 
            // btnReleaseDetainedDrivingLicense
            // 
            btnReleaseDetainedDrivingLicense.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnReleaseDetainedDrivingLicense.Image = Properties.Resources.hand__1_;
            btnReleaseDetainedDrivingLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnReleaseDetainedDrivingLicense.Name = "btnReleaseDetainedDrivingLicense";
            btnReleaseDetainedDrivingLicense.Size = new Size(535, 54);
            btnReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            btnReleaseDetainedDrivingLicense.Click += btnReleaseDetainedDrivingLicense_Click;
            // 
            // btnRetakeTest
            // 
            btnRetakeTest.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnRetakeTest.Image = Properties.Resources.test_reload;
            btnRetakeTest.ImageScaling = ToolStripItemImageScaling.None;
            btnRetakeTest.Name = "btnRetakeTest";
            btnRetakeTest.Size = new Size(535, 54);
            btnRetakeTest.Text = "Retake Test";
            btnRetakeTest.Click += retakeTestToolStripMenuItem_Click;
            // 
            // btnManageApplications
            // 
            btnManageApplications.DropDownItems.AddRange(new ToolStripItem[] { btnlocalDriverLicenseApplication, btnInternationalDriverLicenseApplication });
            btnManageApplications.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnManageApplications.Image = Properties.Resources.papers;
            btnManageApplications.ImageScaling = ToolStripItemImageScaling.None;
            btnManageApplications.Name = "btnManageApplications";
            btnManageApplications.Size = new Size(500, 54);
            btnManageApplications.Text = "Manage Applications";
            // 
            // btnlocalDriverLicenseApplication
            // 
            btnlocalDriverLicenseApplication.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnlocalDriverLicenseApplication.Image = Properties.Resources.id;
            btnlocalDriverLicenseApplication.ImageScaling = ToolStripItemImageScaling.None;
            btnlocalDriverLicenseApplication.Name = "btnlocalDriverLicenseApplication";
            btnlocalDriverLicenseApplication.Size = new Size(564, 54);
            btnlocalDriverLicenseApplication.Text = "Local Driver License Application";
            btnlocalDriverLicenseApplication.Click += btnlocalDriverLicenseApplication_Click;
            // 
            // btnInternationalDriverLicenseApplication
            // 
            btnInternationalDriverLicenseApplication.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnInternationalDriverLicenseApplication.Image = Properties.Resources.world;
            btnInternationalDriverLicenseApplication.ImageScaling = ToolStripItemImageScaling.None;
            btnInternationalDriverLicenseApplication.Name = "btnInternationalDriverLicenseApplication";
            btnInternationalDriverLicenseApplication.Size = new Size(564, 54);
            btnInternationalDriverLicenseApplication.Text = "International Driver License Application";
            btnInternationalDriverLicenseApplication.Click += btnInternationalDriverLicenseApplication_Click;
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.DropDownItems.AddRange(new ToolStripItem[] { btnManagedDetainedLicense, btnDetainLicenses, btnReleaseDetainLicense });
            btnDetainLicense.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnDetainLicense.Image = Properties.Resources.id__1_;
            btnDetainLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.Size = new Size(500, 54);
            btnDetainLicense.Text = "Detain Licenses";
            // 
            // btnManagedDetainedLicense
            // 
            btnManagedDetainedLicense.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnManagedDetainedLicense.Image = Properties.Resources.hand_config;
            btnManagedDetainedLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnManagedDetainedLicense.Name = "btnManagedDetainedLicense";
            btnManagedDetainedLicense.Size = new Size(432, 68);
            btnManagedDetainedLicense.Text = "Managed Detained license";
            btnManagedDetainedLicense.Click += btnManagedDetainedLicense_Click;
            // 
            // btnDetainLicenses
            // 
            btnDetainLicenses.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnDetainLicenses.Image = Properties.Resources.hand;
            btnDetainLicenses.ImageScaling = ToolStripItemImageScaling.None;
            btnDetainLicenses.Name = "btnDetainLicenses";
            btnDetainLicenses.Size = new Size(432, 68);
            btnDetainLicenses.Text = "Detain License";
            btnDetainLicenses.Click += btnDetainLicenses_Click;
            // 
            // btnReleaseDetainLicense
            // 
            btnReleaseDetainLicense.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            btnReleaseDetainLicense.Image = Properties.Resources.hand__1_;
            btnReleaseDetainLicense.ImageScaling = ToolStripItemImageScaling.None;
            btnReleaseDetainLicense.Name = "btnReleaseDetainLicense";
            btnReleaseDetainLicense.Size = new Size(432, 68);
            btnReleaseDetainLicense.Text = "Release Detain License";
            btnReleaseDetainLicense.Click += btnReleaseDetainLicense_Click;
            // 
            // btnManageApTypes
            // 
            btnManageApTypes.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnManageApTypes.Image = Properties.Resources.papers__1_;
            btnManageApTypes.ImageScaling = ToolStripItemImageScaling.None;
            btnManageApTypes.Name = "btnManageApTypes";
            btnManageApTypes.Size = new Size(500, 54);
            btnManageApTypes.Text = "Manage Applications Types";
            btnManageApTypes.Click += btnManageApTypes_Click;
            // 
            // btnManageTestTypes
            // 
            btnManageTestTypes.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnManageTestTypes.Image = Properties.Resources.test_config;
            btnManageTestTypes.ImageScaling = ToolStripItemImageScaling.None;
            btnManageTestTypes.Name = "btnManageTestTypes";
            btnManageTestTypes.Size = new Size(500, 54);
            btnManageTestTypes.Text = "Manage Test Types";
            btnManageTestTypes.Click += btnManageTestTypes_Click;
            // 
            // btnPeople
            // 
            btnPeople.Image = Properties.Resources.users;
            btnPeople.ImageScaling = ToolStripItemImageScaling.None;
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(233, 101);
            btnPeople.Text = "People";
            btnPeople.Click += toolStripMenuItem1_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Image = Properties.Resources.driver;
            btnDrivers.ImageScaling = ToolStripItemImageScaling.None;
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(238, 101);
            btnDrivers.Text = "Drivers";
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnusers
            // 
            btnusers.Image = Properties.Resources.clients_config;
            btnusers.ImageScaling = ToolStripItemImageScaling.None;
            btnusers.Name = "btnusers";
            btnusers.Size = new Size(215, 101);
            btnusers.Text = "Users";
            btnusers.Click += btnusers_Click;
            // 
            // btnAccountSettings
            // 
            btnAccountSettings.DropDownItems.AddRange(new ToolStripItem[] { btnCurrentUserInfo, btnChangePassword, btnSignOut });
            btnAccountSettings.Image = Properties.Resources.account_settings;
            btnAccountSettings.ImageScaling = ToolStripItemImageScaling.None;
            btnAccountSettings.Name = "btnAccountSettings";
            btnAccountSettings.Size = new Size(429, 101);
            btnAccountSettings.Text = "Account Settings";
            // 
            // btnCurrentUserInfo
            // 
            btnCurrentUserInfo.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnCurrentUserInfo.Image = Properties.Resources.patient_information__1_;
            btnCurrentUserInfo.ImageScaling = ToolStripItemImageScaling.None;
            btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            btnCurrentUserInfo.Size = new Size(373, 54);
            btnCurrentUserInfo.Text = "Current User Info";
            btnCurrentUserInfo.Click += btnCurrentUserInfo_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnChangePassword.Image = Properties.Resources.password;
            btnChangePassword.ImageScaling = ToolStripItemImageScaling.None;
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(373, 54);
            btnChangePassword.Text = "Change Password";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnSignOut.Image = Properties.Resources.sign_out;
            btnSignOut.ImageScaling = ToolStripItemImageScaling.None;
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(373, 54);
            btnSignOut.Text = "Sign out";
            btnSignOut.Click += btnSignOut_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Flux_Dev_Design_a_modern_sleek_logo_for_a_driver_license_manag_2_removebg_preview__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1898, 1024);
            Controls.Add(msMain);
            DoubleBuffered = true;
            Font = new Font("Arial Black", 14F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(5);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DVLD";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmMain_FormClosed;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip msMain;
        private ToolStripMenuItem btnApplication;
        private ToolStripMenuItem btnPeople;
        private ToolStripMenuItem btnDrivers;
        private ToolStripMenuItem btnusers;
        private ToolStripMenuItem btnAccountSettings;
        private ToolStripMenuItem btnCurrentUserInfo;
        private ToolStripMenuItem btnChangePassword;
        private ToolStripMenuItem btnSignOut;
        private ToolStripMenuItem btnDrivingLicenseService;
        private ToolStripMenuItem btnManageApplications;
        private ToolStripMenuItem btnDetainLicense;
        private ToolStripMenuItem btnManageApTypes;
        private ToolStripMenuItem btnManageTestTypes;
        private ToolStripMenuItem btnNewDrivingLicense;
        private ToolStripMenuItem btnRenewDrivingLicense;
        private ToolStripMenuItem btnReplacmentLostOrDamagedLicense;
        private ToolStripMenuItem btnReleaseDetainedDrivingLicense;
        private ToolStripMenuItem btnRetakeTest;
        private ToolStripMenuItem btnLocalLicense;
        private ToolStripMenuItem btnInternationalLicense;
        private ToolStripMenuItem btnlocalDriverLicenseApplication;
        private ToolStripMenuItem btnInternationalDriverLicenseApplication;
        private ToolStripMenuItem btnManagedDetainedLicense;
        private ToolStripMenuItem btnDetainLicenses;
        private ToolStripMenuItem btnReleaseDetainLicense;
    }
}
