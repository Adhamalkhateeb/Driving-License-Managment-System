namespace DVLD
{
    partial class frmManageDrivers
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
            cmbFilter = new ComboBox();
            label3 = new Label();
            dgvDrivers = new DataGridView();
            cmsDrivers = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Location = new Point(388, 299);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 36);
            txtFilter.TabIndex = 17;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblCount.Location = new Point(13, 749);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(234, 33);
            lblCount.TabIndex = 16;
            lblCount.Text = "# Records [????]";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cmbFilter.Location = new Point(152, 298);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(231, 32);
            cmbFilter.TabIndex = 14;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label3.Location = new Point(13, 295);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 13;
            label3.Text = "Filter By:";
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.BackgroundColor = Color.White;
            dgvDrivers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.ContextMenuStrip = cmsDrivers;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDrivers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDrivers.GridColor = Color.Black;
            dgvDrivers.Location = new Point(13, 339);
            dgvDrivers.Margin = new Padding(2);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDrivers.RowHeadersWidth = 62;
            dgvDrivers.Size = new Size(1869, 408);
            dgvDrivers.TabIndex = 12;
            // 
            // cmsDrivers
            // 
            cmsDrivers.Font = new Font("Arial Black", 12F);
            cmsDrivers.ImageScalingSize = new Size(20, 20);
            cmsDrivers.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showToolStripMenuItem });
            cmsDrivers.Name = "cmsInternational";
            cmsDrivers.Size = new Size(446, 166);
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
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.driver_license__2_;
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(490, 54);
            showLicenseDetailsToolStripMenuItem.Text = "Issue International License ";
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(780, 209);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(339, 52);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.driver__1_;
            pictureBox1.Location = new Point(798, 1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1741, 764);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 46);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // frmManageDrivers
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1894, 858);
            Controls.Add(btnClose);
            Controls.Add(txtFilter);
            Controls.Add(lblCount);
            Controls.Add(cmbFilter);
            Controls.Add(label3);
            Controls.Add(dgvDrivers);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmManageDrivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Drivers";
            Load += frmManageDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Label lblCount;
        private ComboBox cmbFilter;
        private Label label3;
        private DataGridView dgvDrivers;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Button btnClose;
        private ContextMenuStrip cmsDrivers;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
    }
}