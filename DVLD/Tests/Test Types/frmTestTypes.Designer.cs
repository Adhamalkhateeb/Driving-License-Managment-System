namespace DVLD
{
    partial class frmTestTypes
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
            btnClose = new Button();
            lblCount = new Label();
            dgvTestTypes = new DataGridView();
            cmsTestTypes = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(1025, 743);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(184, 79);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lblCount.Location = new Point(12, 743);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(192, 28);
            lblCount.TabIndex = 23;
            lblCount.Text = "# Records [????]";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = cmsTestTypes;
            dgvTestTypes.GridColor = SystemColors.ActiveCaptionText;
            dgvTestTypes.Location = new Point(12, 334);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dgvTestTypes.RowHeadersWidth = 62;
            dgvTestTypes.Size = new Size(1196, 395);
            dgvTestTypes.TabIndex = 22;
            // 
            // cmsTestTypes
            // 
            cmsTestTypes.ImageScalingSize = new Size(24, 24);
            cmsTestTypes.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            cmsTestTypes.Name = "cmsApplicationTypes";
            cmsTestTypes.Size = new Size(262, 42);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Rockwell Extra Bold", 12F);
            editToolStripMenuItem.Image = Properties.Resources.pen;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(261, 38);
            editToolStripMenuItem.Text = "Edit Test Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(498, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(408, 254);
            label1.Name = "label1";
            label1.Size = new Size(334, 42);
            label1.TabIndex = 20;
            label1.Text = "Manage Test Types";
            // 
            // frmTestTypes
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1220, 829);
            Controls.Add(btnClose);
            Controls.Add(lblCount);
            Controls.Add(dgvTestTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Types";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblCount;
        private DataGridView dgvTestTypes;
        private PictureBox pictureBox1;
        private Label label1;
        private ContextMenuStrip cmsTestTypes;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}