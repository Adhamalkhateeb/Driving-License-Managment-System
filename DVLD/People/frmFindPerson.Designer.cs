namespace DVLD
{
    partial class frmFindPerson
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
            label1 = new Label();
            btnClose = new Button();
            ctrlPersonCardWithFilter2 = new ctrlPersonCardWithFilter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 30F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(363, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 70);
            label1.TabIndex = 1;
            label1.Text = "Find Person";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(870, 572);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(195, 73);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlPersonCardWithFilter2
            // 
            ctrlPersonCardWithFilter2.FilterEnabled = true;
            ctrlPersonCardWithFilter2.Font = new Font("Segoe UI", 6F);
            ctrlPersonCardWithFilter2.Location = new Point(11, 94);
            ctrlPersonCardWithFilter2.Margin = new Padding(2);
            ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            ctrlPersonCardWithFilter2.ShowAddPerson = true;
            ctrlPersonCardWithFilter2.Size = new Size(1064, 473);
            ctrlPersonCardWithFilter2.TabIndex = 19;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1077, 657);
            Controls.Add(ctrlPersonCardWithFilter2);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmFindPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Person";
            Load += frmFindPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnClose;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
    }
}