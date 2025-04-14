namespace DVLD
{
    partial class frmManagePeople
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvPeople = new DataGridView();
            cmsPerson = new ContextMenuStrip(components);
            tsShowDetails = new ToolStripMenuItem();
            tsAddNew = new ToolStripMenuItem();
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            tsPhone = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            cmbFilter = new ComboBox();
            btnClose = new Button();
            btnAdd = new Button();
            lblCount = new Label();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            cmsPerson.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.users__1_;
            pictureBox1.Location = new Point(799, -3);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(781, 205);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 52);
            label1.TabIndex = 1;
            label1.Text = "Manage People";
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Brown;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = cmsPerson;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPeople.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.GridColor = Color.Black;
            dgvPeople.Location = new Point(14, 335);
            dgvPeople.Margin = new Padding(2);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPeople.RowHeadersWidth = 62;
            dgvPeople.Size = new Size(1869, 388);
            dgvPeople.TabIndex = 2;
            dgvPeople.CellDoubleClick += dgvPeople_CellDoubleClick;
            // 
            // cmsPerson
            // 
            cmsPerson.Font = new Font("Arial Black", 12F);
            cmsPerson.ImageScalingSize = new Size(24, 24);
            cmsPerson.Items.AddRange(new ToolStripItem[] { tsShowDetails, tsAddNew, tsEdit, tsDelete, sendEmailToolStripMenuItem, tsPhone });
            cmsPerson.Name = "cmsPerson";
            cmsPerson.Size = new Size(279, 232);
            // 
            // tsShowDetails
            // 
            tsShowDetails.Image = Properties.Resources.list;
            tsShowDetails.ImageScaling = ToolStripItemImageScaling.None;
            tsShowDetails.Name = "tsShowDetails";
            tsShowDetails.Size = new Size(278, 38);
            tsShowDetails.Text = "Show Details";
            tsShowDetails.Click += tsShowDetails_Click;
            // 
            // tsAddNew
            // 
            tsAddNew.Image = Properties.Resources.incorporation;
            tsAddNew.ImageScaling = ToolStripItemImageScaling.None;
            tsAddNew.Name = "tsAddNew";
            tsAddNew.Size = new Size(278, 38);
            tsAddNew.Text = "Add New Person";
            tsAddNew.Click += tsAddNew_Click;
            // 
            // tsEdit
            // 
            tsEdit.Image = Properties.Resources.pen;
            tsEdit.ImageScaling = ToolStripItemImageScaling.None;
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(278, 38);
            tsEdit.Text = "Edit";
            tsEdit.Click += tsEdit_Click;
            // 
            // tsDelete
            // 
            tsDelete.Image = Properties.Resources.delete;
            tsDelete.ImageScaling = ToolStripItemImageScaling.None;
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(278, 38);
            tsDelete.Text = "Delete";
            tsDelete.Click += tsDelete_Click;
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.email;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(278, 38);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // tsPhone
            // 
            tsPhone.Image = Properties.Resources.phone_call;
            tsPhone.ImageScaling = ToolStripItemImageScaling.None;
            tsPhone.Name = "tsPhone";
            tsPhone.Size = new Size(278, 38);
            tsPhone.Text = "Phone Call";
            tsPhone.Click += tsPhone_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 520);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label3.Location = new Point(14, 291);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 33);
            label3.TabIndex = 4;
            label3.Text = "Filter By:";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Arial Black", 10F, FontStyle.Bold);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "None", "Person ID", "National Number", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gendor", "Phone", "Email" });
            cmbFilter.Location = new Point(153, 294);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(231, 32);
            cmbFilter.TabIndex = 5;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(1699, 745);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(184, 74);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.user_add;
            btnAdd.Location = new Point(1796, 280);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 51);
            btnAdd.TabIndex = 7;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblCount.Location = new Point(14, 725);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(234, 33);
            lblCount.TabIndex = 8;
            lblCount.Text = "# Records [????]";
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Location = new Point(389, 295);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 31);
            txtFilter.TabIndex = 9;
            txtFilter.Visible = false;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // frmManagePeople
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1894, 858);
            Controls.Add(txtFilter);
            Controls.Add(lblCount);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(cmbFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvPeople);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Black", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmManagePeople";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage People";
            Load += frmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            cmsPerson.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvPeople;
        private Label label2;
        private Label label3;
        private ComboBox cmbFilter;
        private Button btnClose;
        private Button btnAdd;
        private Label lblCount;
        private ContextMenuStrip cmsPerson;
        private ToolStripMenuItem tsShowDetails;
        private ToolStripMenuItem tsAddNew;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem tsPhone;
        private TextBox txtFilter;
    }
}