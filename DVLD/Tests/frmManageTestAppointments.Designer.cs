namespace DVLD
{
    partial class frmManageTestAppointments
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
            pbManageTests = new PictureBox();
            lblTitle = new Label();
            dgvTestAppointments = new DataGridView();
            cmsAppointments = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            label2 = new Label();
            btnAdd = new Button();
            lblCount = new Label();
            btnClose = new Button();
            ctrlDrivingLicenseApplicationInfo1 = new ctrlDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)pbManageTests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestAppointments).BeginInit();
            cmsAppointments.SuspendLayout();
            SuspendLayout();
            // 
            // pbManageTests
            // 
            pbManageTests.Image = Properties.Resources.Vision_512;
            pbManageTests.Location = new Point(423, -5);
            pbManageTests.Name = "pbManageTests";
            pbManageTests.Size = new Size(223, 140);
            pbManageTests.SizeMode = PictureBoxSizeMode.Zoom;
            pbManageTests.TabIndex = 27;
            pbManageTests.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(315, 121);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(438, 42);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Vision Test Appointments";
            // 
            // dgvTestAppointments
            // 
            dgvTestAppointments.AllowUserToAddRows = false;
            dgvTestAppointments.AllowUserToDeleteRows = false;
            dgvTestAppointments.AllowUserToOrderColumns = true;
            dgvTestAppointments.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestAppointments.ContextMenuStrip = cmsAppointments;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTestAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTestAppointments.GridColor = SystemColors.InactiveCaptionText;
            dgvTestAppointments.Location = new Point(12, 608);
            dgvTestAppointments.Name = "dgvTestAppointments";
            dgvTestAppointments.ReadOnly = true;
            dgvTestAppointments.RowHeadersWidth = 51;
            dgvTestAppointments.Size = new Size(1047, 195);
            dgvTestAppointments.TabIndex = 30;
            // 
            // cmsAppointments
            // 
            cmsAppointments.ImageScalingSize = new Size(20, 20);
            cmsAppointments.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            cmsAppointments.Name = "cmsAppointments";
            cmsAppointments.Size = new Size(279, 80);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Arial Black", 11F);
            toolStripMenuItem2.Image = Properties.Resources.pen;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(278, 38);
            toolStripMenuItem2.Text = "Edit Appointment";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("Arial Black", 11F);
            toolStripMenuItem3.Image = Properties.Resources.test_check;
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(278, 38);
            toolStripMenuItem3.Text = "Take Test";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F);
            label2.Location = new Point(12, 565);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 31;
            label2.Text = "Appointments :";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.date_add__1_;
            btnAdd.Location = new Point(1007, 566);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 37);
            btnAdd.TabIndex = 32;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            lblCount.Location = new Point(12, 806);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(162, 24);
            lblCount.TabIndex = 33;
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
            btnClose.Location = new Point(940, 821);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 44);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Arial Black", 12F);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(12, 166);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(5, 3, 5, 3);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(1054, 401);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 29;
            // 
            // frmManageTestAppointments
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1069, 869);
            Controls.Add(btnClose);
            Controls.Add(lblCount);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(dgvTestAppointments);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Controls.Add(lblTitle);
            Controls.Add(pbManageTests);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmManageTestAppointments";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Test Appointments";
            Load += frmManageTestAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)pbManageTests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTestAppointments).EndInit();
            cmsAppointments.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbManageTests;
        private Label lblTitle;
        private DataGridView dgvTestAppointments;
        private Label label2;
        private Button btnAdd;
        private Label lblCount;
        private Button btnClose;
        private ContextMenuStrip cmsAppointments;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
    }
}