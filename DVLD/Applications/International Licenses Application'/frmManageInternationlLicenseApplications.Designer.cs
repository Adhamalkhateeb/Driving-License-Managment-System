namespace DVLD
{
    partial class frmManageInternationlLicenseApplications
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
            cbStatus = new ComboBox();
            btnAdd = new Button();
            txtFilter = new TextBox();
            lblCount = new Label();
            btnClose = new Button();
            cbFilter = new ComboBox();
            label3 = new Label();
            dgvInternationalDrivingLicenseApplications = new DataGridView();
            cmsInternational = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalDrivingLicenseApplications).BeginInit();
            cmsInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.BackColor = SystemColors.Control;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "All", "Active", "In Active" });
            cbStatus.Location = new Point(388, 309);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(156, 30);
            cbStatus.TabIndex = 38;
            cbStatus.Visible = false;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.papers__2_;
            btnAdd.Location = new Point(1783, 276);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 62);
            btnAdd.TabIndex = 37;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Font = new Font("Segoe UI", 9F);
            txtFilter.Location = new Point(388, 309);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(233, 27);
            txtFilter.TabIndex = 35;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblCount.Location = new Point(13, 771);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(234, 33);
            lblCount.TabIndex = 34;
            lblCount.Text = "# Records [????]";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1751, 781);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 46);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Inter. License ID", "Application ID", "Driver ID", "Local License ID", "Activity" });
            cbFilter.Location = new Point(172, 309);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(193, 32);
            cbFilter.TabIndex = 32;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label3.Location = new Point(14, 305);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 31;
            label3.Text = "Filter By:";
            // 
            // dgvInternationalDrivingLicenseApplications
            // 
            dgvInternationalDrivingLicenseApplications.AllowUserToAddRows = false;
            dgvInternationalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dgvInternationalDrivingLicenseApplications.BackgroundColor = Color.White;
            dgvInternationalDrivingLicenseApplications.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInternationalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInternationalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalDrivingLicenseApplications.ContextMenuStrip = cmsInternational;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInternationalDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInternationalDrivingLicenseApplications.GridColor = Color.Black;
            dgvInternationalDrivingLicenseApplications.Location = new Point(13, 347);
            dgvInternationalDrivingLicenseApplications.Margin = new Padding(2);
            dgvInternationalDrivingLicenseApplications.Name = "dgvInternationalDrivingLicenseApplications";
            dgvInternationalDrivingLicenseApplications.ReadOnly = true;
            dgvInternationalDrivingLicenseApplications.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInternationalDrivingLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInternationalDrivingLicenseApplications.RowHeadersWidth = 62;
            dgvInternationalDrivingLicenseApplications.Size = new Size(1869, 412);
            dgvInternationalDrivingLicenseApplications.TabIndex = 30;
            // 
            // cmsInternational
            // 
            cmsInternational.Font = new Font("Arial Black", 12F);
            cmsInternational.ImageScalingSize = new Size(20, 20);
            cmsInternational.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showToolStripMenuItem });
            cmsInternational.Name = "cmsInternational";
            cmsInternational.Size = new Size(446, 166);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.patient_information__1_;
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(445, 54);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.id;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(445, 54);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(445, 54);
            showToolStripMenuItem.Text = "Show Person Licenses History";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.driver_license__1_;
            pictureBox1.Location = new Point(812, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(545, 233);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(805, 48);
            label1.TabIndex = 36;
            label1.Text = "International Driving License Applications";
            // 
            // frmManageInternationlLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1894, 858);
            Controls.Add(cbStatus);
            Controls.Add(btnAdd);
            Controls.Add(txtFilter);
            Controls.Add(lblCount);
            Controls.Add(btnClose);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(dgvInternationalDrivingLicenseApplications);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageInternationlLicenseApplications";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Internationl License Applications";
            Load += frmManageInternationlLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInternationalDrivingLicenseApplications).EndInit();
            cmsInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private Button btnAdd;
        private TextBox txtFilter;
        private Label lblCount;
        private Button btnClose;
        private ComboBox cbFilter;
        private Label label3;
        private DataGridView dgvInternationalDrivingLicenseApplications;
        private PictureBox pictureBox1;
        private Label label1;
        private ContextMenuStrip cmsInternational;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
    }
}