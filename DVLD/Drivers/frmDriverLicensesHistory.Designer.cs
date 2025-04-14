namespace DVLD
{
    partial class frmDriverLicensesHistory
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
            ctrlAllDriverLicenses1 = new ctrlAllDriverLicenses();
            ctrlPersonCardWithFilter1 = new ctrlPersonCardWithFilter();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlAllDriverLicenses1
            // 
            ctrlAllDriverLicenses1.Font = new Font("Arial Black", 10F);
            ctrlAllDriverLicenses1.Location = new Point(5, 474);
            ctrlAllDriverLicenses1.Margin = new Padding(4, 3, 4, 3);
            ctrlAllDriverLicenses1.Name = "ctrlAllDriverLicenses1";
            ctrlAllDriverLicenses1.Size = new Size(1059, 440);
            ctrlAllDriverLicenses1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Font = new Font("Segoe UI", 6F);
            ctrlPersonCardWithFilter1.Location = new Point(5, 11);
            ctrlPersonCardWithFilter1.Margin = new Padding(2);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(1043, 465);
            ctrlPersonCardWithFilter1.TabIndex = 1;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(926, 887);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 46);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmDriverLicensesHistory
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1059, 940);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCardWithFilter1);
            Controls.Add(ctrlAllDriverLicenses1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmDriverLicensesHistory";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driver Licenses History";
            Load += frmDriverLicensesHistory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ctrlAllDriverLicenses ctrlAllDriverLicenses1;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Button btnClose;
    }
}