namespace DVLD
{
    partial class frmLogin
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
            pbLoginImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            chkRemeberMe = new CheckBox();
            btnLogin = new Button();
            btnShowPass = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLoginImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbLoginImage
            // 
            pbLoginImage.BackColor = Color.DimGray;
            pbLoginImage.Dock = DockStyle.Left;
            pbLoginImage.Image = Properties.Resources.Flux_Dev_Design_a_modern_sleek_logo_for_a_driver_license_manag_2_removebg_preview;
            pbLoginImage.Location = new Point(0, 0);
            pbLoginImage.Margin = new Padding(4);
            pbLoginImage.Name = "pbLoginImage";
            pbLoginImage.Size = new Size(522, 644);
            pbLoginImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoginImage.TabIndex = 0;
            pbLoginImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F);
            label1.Location = new Point(571, 257);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F);
            label2.Location = new Point(571, 328);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(804, 257);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(804, 328);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(871, 258);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(253, 36);
            txtUserName.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(871, 324);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(253, 36);
            txtPass.TabIndex = 6;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 20F);
            label3.Location = new Point(679, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(342, 39);
            label3.TabIndex = 7;
            label3.Text = "Login to your Account";
            label3.Click += label3_Click;
            // 
            // chkRemeberMe
            // 
            chkRemeberMe.AutoSize = true;
            chkRemeberMe.Font = new Font("Arial Black", 9F);
            chkRemeberMe.Location = new Point(804, 387);
            chkRemeberMe.Margin = new Padding(4);
            chkRemeberMe.Name = "chkRemeberMe";
            chkRemeberMe.Size = new Size(151, 26);
            chkRemeberMe.TabIndex = 8;
            chkRemeberMe.Text = "Remember me";
            chkRemeberMe.UseVisualStyleBackColor = true;
            chkRemeberMe.CheckedChanged += chkRemeberMe_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 3;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Black", 13F);
            btnLogin.Image = Properties.Resources.active_user__1_;
            btnLogin.Location = new Point(765, 512);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 93);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "  Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.FlatAppearance.BorderSize = 3;
            btnShowPass.Font = new Font("Arial Black", 13F);
            btnShowPass.Image = Properties.Resources.hidden;
            btnShowPass.Location = new Point(1138, 324);
            btnShowPass.Margin = new Padding(4);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(61, 42);
            btnShowPass.TabIndex = 10;
            btnShowPass.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnShowPass.UseVisualStyleBackColor = true;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 13F);
            btnClose.Image = Properties.Resources.x_mark;
            btnClose.Location = new Point(1140, 14);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 61);
            btnClose.TabIndex = 11;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1241, 644);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnShowPass);
            Controls.Add(btnLogin);
            Controls.Add(chkRemeberMe);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLoginImage);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbLoginImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLoginImage;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Label label3;
        private CheckBox chkRemeberMe;
        private Button btnLogin;
        private Button btnShowPass;
        private Button btnClose;
    }
}