namespace DVLD
{
    partial class frmLocalDrivingLicenseApplication
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtFilter = new TextBox();
            lblCount = new Label();
            cbFilter = new ComboBox();
            label3 = new Label();
            dgvLocalDrivingLicenseApplications = new DataGridView();
            cmsApplications = new ContextMenuStrip(components);
            tsShowDetails = new ToolStripMenuItem();
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            tsCancelApp = new ToolStripMenuItem();
            SchedualToolTestsStripMenuItem = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            schedulePracticalTestToolStripMenuItem = new ToolStripMenuItem();
            IssueDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            tsShowDrivingLicense = new ToolStripMenuItem();
            showPersonLIcenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAdd = new Button();
            cbStatus = new ComboBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).BeginInit();
            cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Location = new Point(389, 310);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(233, 36);
            txtFilter.TabIndex = 25;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblCount.Location = new Point(14, 775);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(234, 33);
            lblCount.TabIndex = 24;
            lblCount.Text = "# Records [????]";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "L.D.L AppID", "National No.", "Full Name", "Status" });
            cbFilter.Location = new Point(173, 313);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(193, 32);
            cbFilter.TabIndex = 22;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label3.Location = new Point(15, 309);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 21;
            label3.Text = "Filter By:";
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvLocalDrivingLicenseApplications.BackgroundColor = Color.White;
            dgvLocalDrivingLicenseApplications.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalDrivingLicenseApplications.ContextMenuStrip = cmsApplications;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLocalDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalDrivingLicenseApplications.GridColor = Color.Black;
            dgvLocalDrivingLicenseApplications.Location = new Point(14, 351);
            dgvLocalDrivingLicenseApplications.Margin = new Padding(2);
            dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            dgvLocalDrivingLicenseApplications.ReadOnly = true;
            dgvLocalDrivingLicenseApplications.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLocalDrivingLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLocalDrivingLicenseApplications.RowHeadersWidth = 62;
            dgvLocalDrivingLicenseApplications.Size = new Size(1869, 412);
            dgvLocalDrivingLicenseApplications.TabIndex = 20;
            // 
            // cmsApplications
            // 
            cmsApplications.Font = new Font("Arial Black", 13F);
            cmsApplications.ImageScalingSize = new Size(24, 24);
            cmsApplications.Items.AddRange(new ToolStripItem[] { tsShowDetails, tsEdit, tsDelete, tsCancelApp, SchedualToolTestsStripMenuItem, IssueDrivingLicenseToolStripMenuItem, tsShowDrivingLicense, showPersonLIcenseHistoryToolStripMenuItem });
            cmsApplications.Name = "cmsPerson";
            cmsApplications.Size = new Size(459, 308);
            cmsApplications.Opening += cmsApplications_Opening;
            // 
            // tsShowDetails
            // 
            tsShowDetails.Image = Properties.Resources.list;
            tsShowDetails.ImageScaling = ToolStripItemImageScaling.None;
            tsShowDetails.Name = "tsShowDetails";
            tsShowDetails.Size = new Size(458, 38);
            tsShowDetails.Text = "Show Application Details";
            tsShowDetails.Click += tsShowDetails_Click;
            // 
            // tsEdit
            // 
            tsEdit.Image = Properties.Resources.pen;
            tsEdit.ImageScaling = ToolStripItemImageScaling.None;
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(458, 38);
            tsEdit.Text = "Edit Application";
            tsEdit.Click += tsEdit_Click;
            // 
            // tsDelete
            // 
            tsDelete.Image = Properties.Resources.delete;
            tsDelete.ImageScaling = ToolStripItemImageScaling.None;
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(458, 38);
            tsDelete.Text = "Delete Application";
            tsDelete.Click += tsDelete_Click;
            // 
            // tsCancelApp
            // 
            tsCancelApp.Image = Properties.Resources.cancel;
            tsCancelApp.ImageScaling = ToolStripItemImageScaling.None;
            tsCancelApp.Name = "tsCancelApp";
            tsCancelApp.Size = new Size(458, 38);
            tsCancelApp.Text = "Cancel Application";
            tsCancelApp.Click += tsCancel_Click;
            // 
            // SchedualToolTestsStripMenuItem
            // 
            SchedualToolTestsStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, schedulePracticalTestToolStripMenuItem });
            SchedualToolTestsStripMenuItem.Image = Properties.Resources.test;
            SchedualToolTestsStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            SchedualToolTestsStripMenuItem.Name = "SchedualToolTestsStripMenuItem";
            SchedualToolTestsStripMenuItem.Size = new Size(458, 38);
            SchedualToolTestsStripMenuItem.Text = "Schedual Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.Font = new Font("Arial Black", 12F);
            scheduleVisionTestToolStripMenuItem.Image = Properties.Resources.eye__2_;
            scheduleVisionTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(370, 38);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Font = new Font("Arial Black", 12F);
            scheduleWrittenTestToolStripMenuItem.Image = Properties.Resources.writing_language;
            scheduleWrittenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(370, 38);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;
            // 
            // schedulePracticalTestToolStripMenuItem
            // 
            schedulePracticalTestToolStripMenuItem.Enabled = false;
            schedulePracticalTestToolStripMenuItem.Font = new Font("Arial Black", 12F);
            schedulePracticalTestToolStripMenuItem.Image = Properties.Resources.black_car;
            schedulePracticalTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            schedulePracticalTestToolStripMenuItem.Name = "schedulePracticalTestToolStripMenuItem";
            schedulePracticalTestToolStripMenuItem.Size = new Size(370, 38);
            schedulePracticalTestToolStripMenuItem.Text = "Schedule Practical Test";
            schedulePracticalTestToolStripMenuItem.Click += schedulePracticalTestToolStripMenuItem_Click;
            // 
            // IssueDrivingLicenseToolStripMenuItem
            // 
            IssueDrivingLicenseToolStripMenuItem.Enabled = false;
            IssueDrivingLicenseToolStripMenuItem.Image = Properties.Resources.id__5_;
            IssueDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            IssueDrivingLicenseToolStripMenuItem.Name = "IssueDrivingLicenseToolStripMenuItem";
            IssueDrivingLicenseToolStripMenuItem.Size = new Size(458, 38);
            IssueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License";
            IssueDrivingLicenseToolStripMenuItem.Click += IssueDrivingLicenseToolStripMenuItem_Click;
            // 
            // tsShowDrivingLicense
            // 
            tsShowDrivingLicense.Enabled = false;
            tsShowDrivingLicense.Image = Properties.Resources.id__4_;
            tsShowDrivingLicense.ImageScaling = ToolStripItemImageScaling.None;
            tsShowDrivingLicense.Name = "tsShowDrivingLicense";
            tsShowDrivingLicense.Size = new Size(458, 38);
            tsShowDrivingLicense.Text = "Show Driving License";
            tsShowDrivingLicense.Click += tsShowDrivingLicense_Click;
            // 
            // showPersonLIcenseHistoryToolStripMenuItem
            // 
            showPersonLIcenseHistoryToolStripMenuItem.Image = Properties.Resources.medical_history;
            showPersonLIcenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLIcenseHistoryToolStripMenuItem.Name = "showPersonLIcenseHistoryToolStripMenuItem";
            showPersonLIcenseHistoryToolStripMenuItem.Size = new Size(458, 38);
            showPersonLIcenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLIcenseHistoryToolStripMenuItem.Click += showPersonLIcenseHistoryToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account_settings__3___1_;
            pictureBox1.Location = new Point(813, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(614, 237);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(666, 48);
            label1.TabIndex = 26;
            label1.Text = "Local Driving License Applications";
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Image = Properties.Resources.papers__2_;
            btnAdd.Location = new Point(1784, 280);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 62);
            btnAdd.TabIndex = 27;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = SystemColors.Control;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "All", "New", "Cancelled", "Completed" });
            cbStatus.Location = new Point(389, 313);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(156, 32);
            cbStatus.TabIndex = 28;
            cbStatus.Visible = false;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1752, 775);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 46);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // frmLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1894, 858);
            Controls.Add(btnClose);
            Controls.Add(cbStatus);
            Controls.Add(btnAdd);
            Controls.Add(txtFilter);
            Controls.Add(lblCount);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(dgvLocalDrivingLicenseApplications);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmLocalDrivingLicenseApplication";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Driving License Application";
            Load += frmLocalDrivingLicenseApplication_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLocalDrivingLicenseApplications).EndInit();
            cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Label lblCount;
        private ComboBox cbFilter;
        private Label label3;
        private DataGridView dgvLocalDrivingLicenseApplications;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAdd;
        private ComboBox cbStatus;
        private ContextMenuStrip cmsApplications;
        private ToolStripMenuItem tsShowDetails;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
        private ToolStripMenuItem tsCancelApp;
        private ToolStripMenuItem SchedualToolTestsStripMenuItem;
        private ToolStripMenuItem IssueDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem tsShowDrivingLicense;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem schedulePracticalTestToolStripMenuItem;
        private ToolStripMenuItem showPersonLIcenseHistoryToolStripMenuItem;
        private Button btnClose;
    }
}