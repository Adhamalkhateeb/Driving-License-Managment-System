namespace DVLD
{
    partial class frmManageDetainedLicense
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
            btnClose = new Button();
            cbReleased = new ComboBox();
            txtFilter = new TextBox();
            lblCount = new Label();
            cbFilter = new ComboBox();
            label3 = new Label();
            dgvDetainedLicenses = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnDetain = new Button();
            btnRelease = new Button();
            cmsDetainedLicenses = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cmsDetainedLicenses.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1751, 788);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 46);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cbReleased
            // 
            cbReleased.BackColor = SystemColors.Control;
            cbReleased.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReleased.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cbReleased.FormattingEnabled = true;
            cbReleased.Items.AddRange(new object[] { "All", "Released", "Not Released" });
            cbReleased.Location = new Point(388, 322);
            cbReleased.Margin = new Padding(2);
            cbReleased.Name = "cbReleased";
            cbReleased.Size = new Size(156, 32);
            cbReleased.TabIndex = 42;
            cbReleased.Visible = false;
            cbReleased.SelectedIndexChanged += cbReleased_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Font = new Font("Segoe UI", 9F);
            txtFilter.Location = new Point(388, 323);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(233, 27);
            txtFilter.TabIndex = 40;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblCount.Location = new Point(13, 788);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(234, 33);
            lblCount.TabIndex = 39;
            lblCount.Text = "# Records [????]";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Detain ID", "Released", "National No.", "Full Name", "Release Application ID" });
            cbFilter.Location = new Point(172, 323);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(211, 32);
            cbFilter.TabIndex = 38;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label3.Location = new Point(14, 322);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 37;
            label3.Text = "Filter By:";
            // 
            // dgvDetainedLicenses
            // 
            dgvDetainedLicenses.AllowUserToAddRows = false;
            dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dgvDetainedLicenses.BackgroundColor = Color.White;
            dgvDetainedLicenses.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetainedLicenses.ContextMenuStrip = cmsDetainedLicenses;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetainedLicenses.GridColor = Color.Black;
            dgvDetainedLicenses.Location = new Point(13, 364);
            dgvDetainedLicenses.Margin = new Padding(2);
            dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            dgvDetainedLicenses.ReadOnly = true;
            dgvDetainedLicenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetainedLicenses.RowHeadersWidth = 62;
            dgvDetainedLicenses.Size = new Size(1869, 412);
            dgvDetainedLicenses.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.document;
            pictureBox1.Location = new Point(811, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(658, 237);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(578, 48);
            label1.TabIndex = 41;
            label1.Text = "List Detained Driving License ";
            // 
            // btnDetain
            // 
            btnDetain.Cursor = Cursors.Hand;
            btnDetain.Image = Properties.Resources.hand;
            btnDetain.Location = new Point(1783, 284);
            btnDetain.Margin = new Padding(2);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(100, 76);
            btnDetain.TabIndex = 44;
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // btnRelease
            // 
            btnRelease.Cursor = Cursors.Hand;
            btnRelease.Image = Properties.Resources.hand__1_;
            btnRelease.Location = new Point(1679, 284);
            btnRelease.Margin = new Padding(2);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(100, 76);
            btnRelease.TabIndex = 45;
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // cmsDetainedLicenses
            // 
            cmsDetainedLicenses.Font = new Font("Arial Black", 12F);
            cmsDetainedLicenses.ImageScalingSize = new Size(20, 20);
            cmsDetainedLicenses.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            cmsDetainedLicenses.Name = "cmsInternational";
            cmsDetainedLicenses.Size = new Size(446, 220);
            cmsDetainedLicenses.Opening += cmsDetainedLicenses_Opening;
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
            showLicenseDetailsToolStripMenuItem.AutoSize = false;
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.id;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(490, 54);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Info";
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
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = Properties.Resources.hand__1_;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(445, 54);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // frmManageDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1894, 858);
            Controls.Add(btnRelease);
            Controls.Add(btnDetain);
            Controls.Add(btnClose);
            Controls.Add(cbReleased);
            Controls.Add(txtFilter);
            Controls.Add(lblCount);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(dgvDetainedLicenses);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageDetainedLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Detained License";
            Load += frmManageDetainedLicense_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetainedLicenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cmsDetainedLicenses.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private ComboBox cbReleased;
        private TextBox txtFilter;
        private Label lblCount;
        private ComboBox cbFilter;
        private Label label3;
        private DataGridView dgvDetainedLicenses;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDetain;
        private Button btnRelease;
        private ContextMenuStrip cmsDetainedLicenses;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}