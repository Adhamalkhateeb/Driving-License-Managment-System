namespace DVLD
{
    partial class frmApplicationTypes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvApplicationTypes = new DataGridView();
            cmsApplicationTypes = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            lblCount = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            cmsApplicationTypes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(339, 242);
            label1.Name = "label1";
            label1.Size = new Size(449, 42);
            label1.TabIndex = 0;
            label1.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(498, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = cmsApplicationTypes;
            dgvApplicationTypes.GridColor = SystemColors.ActiveCaptionText;
            dgvApplicationTypes.Location = new Point(12, 327);
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dgvApplicationTypes.RowHeadersWidth = 62;
            dgvApplicationTypes.Size = new Size(1196, 395);
            dgvApplicationTypes.TabIndex = 2;
            // 
            // cmsApplicationTypes
            // 
            cmsApplicationTypes.ImageScalingSize = new Size(24, 24);
            cmsApplicationTypes.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            cmsApplicationTypes.Name = "cmsApplicationTypes";
            cmsApplicationTypes.Size = new Size(368, 58);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Rockwell Extra Bold", 12F);
            editToolStripMenuItem.Image = Properties.Resources.papers;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(367, 54);
            editToolStripMenuItem.Text = "Edit Application Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lblCount.Location = new Point(12, 736);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(192, 28);
            lblCount.TabIndex = 18;
            lblCount.Text = "# Records [????]";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(1025, 736);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(184, 79);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1220, 829);
            Controls.Add(btnClose);
            Controls.Add(lblCount);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmApplicationTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application Types";
            Load += frmApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            cmsApplicationTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvApplicationTypes;
        private Label lblCount;
        private Button btnClose;
        private ContextMenuStrip cmsApplicationTypes;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}