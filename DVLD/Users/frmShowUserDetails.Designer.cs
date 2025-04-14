namespace DVLD
{
    partial class frmShowUserDetails
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
            ctrlUserCard1 = new ctrlUserCard();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 59);
            label1.TabIndex = 2;
            label1.Text = "User Details";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(844, 534);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(193, 79);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(15, 95);
            ctrlUserCard1.Margin = new Padding(2);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(1036, 435);
            ctrlUserCard1.TabIndex = 17;
            // 
            // frmShowUserDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1049, 618);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(ctrlUserCard1);
            Cursor = Cursors.Hand;
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmShowUserDetails";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Details";
            Load += frmShowUserDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnClose;
        private ctrlUserCard ctrlUserCard1;
    }
}