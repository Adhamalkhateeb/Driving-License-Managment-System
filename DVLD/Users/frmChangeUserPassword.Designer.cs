namespace DVLD
{
    partial class frmChangeUserPassword
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
            ctrlUserCard1 = new ctrlUserCard();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtCurrentPass = new TextBox();
            btnShowPass = new Button();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 12);
            ctrlUserCard1.Margin = new Padding(2);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(1028, 445);
            ctrlUserCard1.TabIndex = 0;
            ctrlUserCard1.Load += ctrlUserCard1_Load;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Location = new Point(411, 603);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PlaceholderText = "Confirm new pass";
            txtConfirmPass.Size = new Size(327, 31);
            txtConfirmPass.TabIndex = 2;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtConfirmPass.Validating += txtConfirmPass_Validating;
            // 
            // txtNewPass
            // 
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.Location = new Point(411, 533);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PlaceholderText = "Enter new pass";
            txtNewPass.Size = new Size(327, 31);
            txtNewPass.TabIndex = 1;
            txtNewPass.UseSystemPasswordChar = true;
            txtNewPass.Validating += txtNewPass_Validating;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(346, 604);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(346, 530);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 14F);
            label5.Location = new Point(7, 604);
            label5.Name = "label5";
            label5.Size = new Size(272, 33);
            label5.TabIndex = 15;
            label5.Text = "Confirm Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 14F);
            label4.Location = new Point(60, 530);
            label4.Name = "label4";
            label4.Size = new Size(227, 33);
            label4.TabIndex = 16;
            label4.Text = "New Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14F);
            label1.Location = new Point(12, 459);
            label1.Name = "label1";
            label1.Size = new Size(269, 33);
            label1.TabIndex = 23;
            label1.Text = "Current Password :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.password;
            pictureBox1.Location = new Point(346, 459);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPass.Location = new Point(411, 459);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.PlaceholderText = "Enter Current Pass";
            txtCurrentPass.Size = new Size(327, 31);
            txtCurrentPass.TabIndex = 0;
            txtCurrentPass.UseSystemPasswordChar = true;
            txtCurrentPass.Validating += txtCurrentPass_Validating;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.Transparent;
            btnShowPass.Cursor = Cursors.Hand;
            btnShowPass.Image = Properties.Resources.hidden;
            btnShowPass.Location = new Point(753, 457);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(56, 35);
            btnShowPass.TabIndex = 26;
            btnShowPass.TabStop = false;
            btnShowPass.Tag = "0";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btn_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CausesValidation = false;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.cross;
            btnClose.Location = new Point(692, 663);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(166, 79);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.favorite_15111499;
            btnSave.Location = new Point(874, 663);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 79);
            btnSave.TabIndex = 3;
            btnSave.Text = " Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1056, 750);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnShowPass);
            Controls.Add(txtCurrentPass);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ctrlUserCard1);
            Font = new Font("Arial Black", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChangeUserPassword";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change User Password";
            Load += frmChangeUserPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtCurrentPass;
        private Button btnShowPass;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}