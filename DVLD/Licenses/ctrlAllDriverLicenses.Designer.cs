namespace DVLD
{
    partial class ctrlAllDriverLicenses
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tabDrivingLicenses = new TabControl();
            tabLocal = new TabPage();
            lblLocalCount = new Label();
            dgvLocalLicenses = new DataGridView();
            cmsLocalLicense = new ContextMenuStrip(components);
            showLicneseToolStripMenuItem = new ToolStripMenuItem();
            lblLocal = new Label();
            tabInternational = new TabPage();
            lblInternationalCount = new Label();
            dgvInternationalLicenses = new DataGridView();
            cmsInternationalLicenses = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            label3 = new Label();
            groupBox1.SuspendLayout();
            tabDrivingLicenses.SuspendLayout();
            tabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).BeginInit();
            cmsLocalLicense.SuspendLayout();
            tabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            cmsInternationalLicenses.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabDrivingLicenses);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1054, 435);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tabDrivingLicenses
            // 
            tabDrivingLicenses.Controls.Add(tabLocal);
            tabDrivingLicenses.Controls.Add(tabInternational);
            tabDrivingLicenses.Location = new Point(6, 30);
            tabDrivingLicenses.Name = "tabDrivingLicenses";
            tabDrivingLicenses.SelectedIndex = 0;
            tabDrivingLicenses.Size = new Size(1047, 405);
            tabDrivingLicenses.TabIndex = 1;
            // 
            // tabLocal
            // 
            tabLocal.Controls.Add(lblLocalCount);
            tabLocal.Controls.Add(dgvLocalLicenses);
            tabLocal.Controls.Add(lblLocal);
            tabLocal.Location = new Point(4, 33);
            tabLocal.Name = "tabLocal";
            tabLocal.Padding = new Padding(3);
            tabLocal.Size = new Size(1039, 368);
            tabLocal.TabIndex = 0;
            tabLocal.Text = "Local";
            tabLocal.UseVisualStyleBackColor = true;
            // 
            // lblLocalCount
            // 
            lblLocalCount.AutoSize = true;
            lblLocalCount.Location = new Point(0, 341);
            lblLocalCount.Name = "lblLocalCount";
            lblLocalCount.Size = new Size(108, 24);
            lblLocalCount.TabIndex = 3;
            lblLocalCount.Text = "# Records ";
            // 
            // dgvLocalLicenses
            // 
            dgvLocalLicenses.AllowUserToAddRows = false;
            dgvLocalLicenses.AllowUserToDeleteRows = false;
            dgvLocalLicenses.AllowUserToOrderColumns = true;
            dgvLocalLicenses.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLocalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicenses.ContextMenuStrip = cmsLocalLicense;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLocalLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalLicenses.Location = new Point(6, 53);
            dgvLocalLicenses.Name = "dgvLocalLicenses";
            dgvLocalLicenses.RowHeadersWidth = 51;
            dgvLocalLicenses.Size = new Size(1028, 285);
            dgvLocalLicenses.TabIndex = 2;
            dgvLocalLicenses.CellContentClick += dgvLocalLicenses_CellContentClick;
            // 
            // cmsLocalLicense
            // 
            cmsLocalLicense.Font = new Font("Arial Black", 12F);
            cmsLocalLicense.ImageScalingSize = new Size(20, 20);
            cmsLocalLicense.Items.AddRange(new ToolStripItem[] { showLicneseToolStripMenuItem });
            cmsLocalLicense.Name = "cmsLicense";
            cmsLocalLicense.Size = new Size(300, 42);
            // 
            // showLicneseToolStripMenuItem
            // 
            showLicneseToolStripMenuItem.Image = Properties.Resources.driver_license;
            showLicneseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicneseToolStripMenuItem.Name = "showLicneseToolStripMenuItem";
            showLicneseToolStripMenuItem.Size = new Size(299, 38);
            showLicneseToolStripMenuItem.Text = "Show Licnese Info";
            showLicneseToolStripMenuItem.Click += showLicneseToolStripMenuItem_Click;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(6, 14);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(233, 24);
            lblLocal.TabIndex = 1;
            lblLocal.Text = "Local Licenses History :";
            // 
            // tabInternational
            // 
            tabInternational.Controls.Add(lblInternationalCount);
            tabInternational.Controls.Add(dgvInternationalLicenses);
            tabInternational.Controls.Add(label3);
            tabInternational.Location = new Point(4, 33);
            tabInternational.Name = "tabInternational";
            tabInternational.Padding = new Padding(3);
            tabInternational.Size = new Size(1039, 368);
            tabInternational.TabIndex = 1;
            tabInternational.Text = "International";
            tabInternational.UseVisualStyleBackColor = true;
            // 
            // lblInternationalCount
            // 
            lblInternationalCount.AutoSize = true;
            lblInternationalCount.Location = new Point(6, 341);
            lblInternationalCount.Name = "lblInternationalCount";
            lblInternationalCount.Size = new Size(108, 24);
            lblInternationalCount.TabIndex = 6;
            lblInternationalCount.Text = "# Records ";
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToOrderColumns = true;
            dgvInternationalLicenses.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = cmsInternationalLicenses;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial Black", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvInternationalLicenses.DefaultCellStyle = dataGridViewCellStyle4;
            dgvInternationalLicenses.Location = new Point(6, 53);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dgvInternationalLicenses.RowHeadersWidth = 51;
            dgvInternationalLicenses.Size = new Size(1028, 285);
            dgvInternationalLicenses.TabIndex = 5;
            // 
            // cmsInternationalLicenses
            // 
            cmsInternationalLicenses.Font = new Font("Arial Black", 12F);
            cmsInternationalLicenses.ImageScalingSize = new Size(20, 20);
            cmsInternationalLicenses.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            cmsInternationalLicenses.Name = "cmsLicense";
            cmsInternationalLicenses.Size = new Size(300, 42);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.driver_license;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(299, 38);
            toolStripMenuItem1.Text = "Show Licnese Info";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 11);
            label3.Name = "label3";
            label3.Size = new Size(304, 24);
            label3.TabIndex = 4;
            label3.Text = "International Licenses History :";
            // 
            // ctrlAllDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Font = new Font("Arial Black", 10F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrlAllDriverLicenses";
            Size = new Size(1062, 441);
            groupBox1.ResumeLayout(false);
            tabDrivingLicenses.ResumeLayout(false);
            tabLocal.ResumeLayout(false);
            tabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).EndInit();
            cmsLocalLicense.ResumeLayout(false);
            tabInternational.ResumeLayout(false);
            tabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            cmsInternationalLicenses.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabDrivingLicenses;
        private TabPage tabLocal;
        private Label lblLocal;
        private TabPage tabInternational;
        private Label lblLocalCount;
        private DataGridView dgvLocalLicenses;
        private Label lblInternationalCount;
        private DataGridView dgvInternationalLicenses;
        private Label label3;
        private ContextMenuStrip cmsLocalLicense;
        private ToolStripMenuItem showLicneseToolStripMenuItem;
        private ContextMenuStrip cmsInternationalLicenses;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
