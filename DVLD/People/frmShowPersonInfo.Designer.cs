namespace DVLD
{
    partial class frmShowPersonInfo
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
            ctrlPersonCard1 = new ctrlPersonCard();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BorderStyle = BorderStyle.FixedSingle;
            ctrlPersonCard1.Font = new Font("Arial Black", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(24, 98);
            ctrlPersonCard1.Margin = new Padding(3, 4, 3, 4);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.ShowUpdatePerson = true;
            ctrlPersonCard1.Size = new Size(1029, 296);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 59);
            label1.TabIndex = 1;
            label1.Text = "Person Details";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 12F);
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(858, 410);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(195, 74);
            btnClose.TabIndex = 7;
            btnClose.Text = " Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1082, 496);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmShowPersonInfo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person's Info";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private Label label1;
        private Button btnClose;
    }
}