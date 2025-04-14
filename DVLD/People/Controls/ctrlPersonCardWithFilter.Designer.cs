namespace DVLD
{
    partial class ctrlPersonCardWithFilter
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
            ctrlPersonCard1 = new ctrlPersonCard();
            gbPersonDetails = new GroupBox();
            gbFilter = new GroupBox();
            btnAddNew = new Button();
            btnSearch = new Button();
            txtFind = new TextBox();
            cbFliter = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbPersonDetails.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(6, 34);
            ctrlPersonCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.ShowUpdatePerson = false;
            ctrlPersonCard1.Size = new Size(1007, 293);
            ctrlPersonCard1.TabIndex = 20;
            ctrlPersonCard1.TabStop = false;
            // 
            // gbPersonDetails
            // 
            gbPersonDetails.Controls.Add(ctrlPersonCard1);
            gbPersonDetails.Font = new Font("Segoe UI", 10F);
            gbPersonDetails.Location = new Point(21, 139);
            gbPersonDetails.Name = "gbPersonDetails";
            gbPersonDetails.Size = new Size(1023, 322);
            gbPersonDetails.TabIndex = 1;
            gbPersonDetails.TabStop = false;
            gbPersonDetails.Text = "Person Details";
            gbPersonDetails.Enter += gbPersonDetails_Enter;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddNew);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(txtFind);
            gbFilter.Controls.Add(cbFliter);
            gbFilter.Controls.Add(label1);
            gbFilter.Font = new Font("Segoe UI", 10F);
            gbFilter.Location = new Point(21, 14);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1023, 109);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            gbFilter.Enter += gbFilter_Enter;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.Transparent;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.FlatAppearance.BorderSize = 2;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Image = Properties.Resources.add_user;
            btnAddNew.Location = new Point(888, 33);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(73, 70);
            btnAddNew.TabIndex = 3;
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.recruitment;
            btnSearch.Location = new Point(809, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(73, 70);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFind
            // 
            txtFind.BorderStyle = BorderStyle.FixedSingle;
            txtFind.Location = new Point(431, 48);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(328, 30);
            txtFind.TabIndex = 1;
            txtFind.KeyPress += txtFind_KeyPress;
            // 
            // cbFliter
            // 
            cbFliter.BackColor = SystemColors.Control;
            cbFliter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFliter.FormattingEnabled = true;
            cbFliter.Items.AddRange(new object[] { "Person ID", "National Number" });
            cbFliter.Location = new Point(175, 46);
            cbFliter.Name = "cbFliter";
            cbFliter.Size = new Size(238, 31);
            cbFliter.TabIndex = 0;
            cbFliter.SelectedIndexChanged += cbFliter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 11F);
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 0;
            label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(gbPersonDetails);
            Font = new Font("Segoe UI", 6F);
            Margin = new Padding(2);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(1073, 470);
            Load += ctrlPersonCardWithFilter_Load;
            gbPersonDetails.ResumeLayout(false);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbPersonDetails;
        private GroupBox gbFilter;
        private Label label1;
        private TextBox txtFind;
        private ComboBox cbFliter;
        private Button btnAddNew;
        private Button btnSearch;
        private ErrorProvider errorProvider1;
    }
}
