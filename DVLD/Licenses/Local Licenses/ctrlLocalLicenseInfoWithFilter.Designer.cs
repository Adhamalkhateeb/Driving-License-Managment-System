namespace DVLD
{
    partial class ctrlLocalLicenseInfoWithFilter
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
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            gbFilter = new GroupBox();
            btnSearch = new Button();
            txtFilter = new TextBox();
            label1 = new Label();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Font = new Font("Arial Black", 10F);
            ctrlDriverLicenseInfo1.Location = new Point(4, 97);
            ctrlDriverLicenseInfo1.Margin = new Padding(4, 3, 4, 3);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1052, 394);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(txtFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Font = new Font("Arial Black", 9F);
            gbFilter.Location = new Point(3, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1045, 88);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Arial Black", 12F);
            btnSearch.Image = Properties.Resources.License_View_32;
            btnSearch.Location = new Point(676, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 54);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFilter
            // 
            txtFilter.BorderStyle = BorderStyle.FixedSingle;
            txtFilter.Font = new Font("Arial Black", 10F);
            txtFilter.Location = new Point(166, 38);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = " Enter Only numbers";
            txtFilter.Size = new Size(482, 31);
            txtFilter.TabIndex = 1;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10F);
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 0;
            label1.Text = "License ID :";
            // 
            // ctrlLocalLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlDriverLicenseInfo1);
            Font = new Font("Arial Black", 10F);
            Margin = new Padding(5, 3, 5, 3);
            Name = "ctrlLocalLicenseInfoWithFilter";
            Size = new Size(1057, 492);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox gbFilter;
        private Button btnSearch;
        private TextBox txtFilter;
        private Label label1;
    }
}
