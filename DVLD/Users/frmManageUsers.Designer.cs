namespace DVLD
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            txtFilter = new TextBox();
            lblCount = new Label();
            btnAdd = new Button();
            cmbFilter = new ComboBox();
            label3 = new Label();
            dgvUsers = new DataGridView();
            cmsuser = new ContextMenuStrip(components);
            tsShowDetails = new ToolStripMenuItem();
            tsAddNew = new ToolStripMenuItem();
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            tsPhone = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cbActive = new ComboBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            cmsuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Location = new Point(374, 284);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(272, 31);
            txtFilter.TabIndex = 18;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblCount.Location = new Point(10, 748);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(234, 33);
            lblCount.TabIndex = 17;
            lblCount.Text = "# Records [????]";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.user_add;
            btnAdd.Location = new Point(1784, 280);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 51);
            btnAdd.TabIndex = 16;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Name", "User Name", "Is Active" });
            cmbFilter.Location = new Point(169, 284);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(182, 32);
            cmbFilter.TabIndex = 14;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label3.Location = new Point(11, 280);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 13;
            label3.Text = "Filter By:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = cmsuser;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(10, 335);
            dgvUsers.Margin = new Padding(2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(1874, 411);
            dgvUsers.TabIndex = 12;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // cmsuser
            // 
            cmsuser.Font = new Font("Arial Black", 12F);
            cmsuser.ImageScalingSize = new Size(24, 24);
            cmsuser.Items.AddRange(new ToolStripItem[] { tsShowDetails, tsAddNew, tsEdit, tsDelete, changePasswordToolStripMenuItem, sendEmailToolStripMenuItem, tsPhone });
            cmsuser.Name = "cmsPerson";
            cmsuser.Size = new Size(309, 382);
            // 
            // tsShowDetails
            // 
            tsShowDetails.Image = Properties.Resources.list;
            tsShowDetails.ImageScaling = ToolStripItemImageScaling.None;
            tsShowDetails.Name = "tsShowDetails";
            tsShowDetails.Size = new Size(308, 54);
            tsShowDetails.Text = "Show Details";
            tsShowDetails.Click += tsShowDetails_Click;
            // 
            // tsAddNew
            // 
            tsAddNew.Image = Properties.Resources.incorporation;
            tsAddNew.ImageScaling = ToolStripItemImageScaling.None;
            tsAddNew.Name = "tsAddNew";
            tsAddNew.Size = new Size(308, 54);
            tsAddNew.Text = "Add New User";
            tsAddNew.Click += tsAddNew_Click;
            // 
            // tsEdit
            // 
            tsEdit.Image = Properties.Resources.pen;
            tsEdit.ImageScaling = ToolStripItemImageScaling.None;
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(308, 54);
            tsEdit.Text = "Edit";
            tsEdit.Click += tsEdit_Click;
            // 
            // tsDelete
            // 
            tsDelete.Image = Properties.Resources.delete;
            tsDelete.ImageScaling = ToolStripItemImageScaling.None;
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(308, 54);
            tsDelete.Text = "Delete";
            tsDelete.Click += tsDelete_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.password;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(308, 54);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.email;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(308, 54);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // tsPhone
            // 
            tsPhone.Image = Properties.Resources.phone_call;
            tsPhone.ImageScaling = ToolStripItemImageScaling.None;
            tsPhone.Name = "tsPhone";
            tsPhone.Size = new Size(308, 54);
            tsPhone.Text = "Phone Call";
            tsPhone.Click += tsPhone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(778, 200);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(338, 56);
            label1.TabIndex = 11;
            label1.Text = "Manage Users";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_400;
            pictureBox1.Location = new Point(788, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cbActive
            // 
            cbActive.BackColor = SystemColors.Control;
            cbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActive.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cbActive.FormattingEnabled = true;
            cbActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbActive.Location = new Point(374, 284);
            cbActive.Margin = new Padding(2);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(156, 32);
            cbActive.TabIndex = 19;
            cbActive.Visible = false;
            cbActive.SelectedIndexChanged += cbActive_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(1767, 766);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 46);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1894, 858);
            Controls.Add(btnClose);
            Controls.Add(cbActive);
            Controls.Add(txtFilter);
            Controls.Add(lblCount);
            Controls.Add(btnAdd);
            Controls.Add(cmbFilter);
            Controls.Add(label3);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmManageUsers";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            cmsuser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Label lblCount;
        private Button btnAdd;
        private ComboBox cmbFilter;
        private Label label3;
        private DataGridView dgvUsers;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cbActive;
        private ContextMenuStrip cmsuser;
        private ToolStripMenuItem tsShowDetails;
        private ToolStripMenuItem tsAddNew;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem tsPhone;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private Button btnClose;
    }
}