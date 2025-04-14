namespace DVLD
{
    partial class ctrlUserCard
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
            ctrlPersonCard1 = new ctrlPersonCard();
            gbPersonInfo = new GroupBox();
            gbUserInfo = new GroupBox();
            lblIsActive = new Label();
            label5 = new Label();
            lblUserName = new Label();
            label3 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            gbPersonInfo.SuspendLayout();
            gbUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(5, 25);
            ctrlPersonCard1.Margin = new Padding(2, 3, 2, 3);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.ShowUpdatePerson = true;
            ctrlPersonCard1.Size = new Size(1010, 285);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbPersonInfo
            // 
            gbPersonInfo.Controls.Add(ctrlPersonCard1);
            gbPersonInfo.FlatStyle = FlatStyle.System;
            gbPersonInfo.Location = new Point(2, 10);
            gbPersonInfo.Margin = new Padding(2);
            gbPersonInfo.Name = "gbPersonInfo";
            gbPersonInfo.Padding = new Padding(2);
            gbPersonInfo.Size = new Size(1019, 315);
            gbPersonInfo.TabIndex = 0;
            gbPersonInfo.TabStop = false;
            gbPersonInfo.Text = "Person Info";
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(lblIsActive);
            gbUserInfo.Controls.Add(label5);
            gbUserInfo.Controls.Add(lblUserName);
            gbUserInfo.Controls.Add(label3);
            gbUserInfo.Controls.Add(lblUserID);
            gbUserInfo.Controls.Add(label1);
            gbUserInfo.FlatStyle = FlatStyle.System;
            gbUserInfo.Font = new Font("Arial Black", 10F);
            gbUserInfo.Location = new Point(7, 329);
            gbUserInfo.Margin = new Padding(2);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Padding = new Padding(2);
            gbUserInfo.Size = new Size(1014, 90);
            gbUserInfo.TabIndex = 1;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "Login Info";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Arial Black", 10F);
            lblIsActive.Location = new Point(776, 41);
            lblIsActive.Margin = new Padding(2, 0, 2, 0);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(64, 24);
            lblIsActive.TabIndex = 5;
            lblIsActive.Text = "[????]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 10F);
            label5.Location = new Point(674, 41);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 24);
            label5.TabIndex = 4;
            label5.Text = "Is Active :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial Black", 10F);
            lblUserName.Location = new Point(483, 41);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(64, 24);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "[????]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 10F);
            label3.Location = new Point(361, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "User Name :";
            // 
            // lblUserID
            // 
            lblUserID.AutoEllipsis = true;
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Arial Black", 10F);
            lblUserID.Location = new Point(193, 41);
            lblUserID.Margin = new Padding(2, 0, 2, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(42, 24);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10F);
            label1.Location = new Point(102, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // ctrlUserCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(gbUserInfo);
            Controls.Add(gbPersonInfo);
            Margin = new Padding(2);
            Name = "ctrlUserCard";
            Size = new Size(1036, 437);
            Load += ctrlUserCard_Load;
            gbPersonInfo.ResumeLayout(false);
            gbUserInfo.ResumeLayout(false);
            gbUserInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbPersonInfo;
        private GroupBox gbUserInfo;
        private Label lblUserID;
        private Label label1;
        private Label lblIsActive;
        private Label label5;
        private Label lblUserName;
        private Label label3;
    }
}
