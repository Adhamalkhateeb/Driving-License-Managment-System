namespace DVLD
{
    partial class frmAdd_UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_UpdateUser));
            tabControl1 = new TabControl();
            tabPersonalInfo = new TabPage();
            ctrlPersonCardWithFilter2 = new ctrlPersonCardWithFilter();
            btnNext = new Button();
            tabLogin = new TabPage();
            llUpdatePass = new LinkLabel();
            pictureBox5 = new PictureBox();
            chkActive = new CheckBox();
            label7 = new Label();
            btnConfirmPass = new Button();
            btnPass = new Button();
            txtConfirmPass = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            pbConfirmPassword = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblUserID = new Label();
            pictureBox1 = new PictureBox();
            lblConfirmPassword = new Label();
            label4 = new Label();
            label3 = new Label();
            ctrlPersonCard1 = new ctrlPersonCard();
            label2 = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPersonalInfo);
            tabControl1.Controls.Add(tabLogin);
            errorProvider1.SetError(tabControl1, resources.GetString("tabControl1.Error"));
            errorProvider1.SetIconAlignment(tabControl1, (ErrorIconAlignment)resources.GetObject("tabControl1.IconAlignment"));
            errorProvider1.SetIconPadding(tabControl1, (int)resources.GetObject("tabControl1.IconPadding"));
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPersonalInfo
            // 
            resources.ApplyResources(tabPersonalInfo, "tabPersonalInfo");
            tabPersonalInfo.Controls.Add(ctrlPersonCardWithFilter2);
            tabPersonalInfo.Controls.Add(btnNext);
            errorProvider1.SetError(tabPersonalInfo, resources.GetString("tabPersonalInfo.Error"));
            errorProvider1.SetIconAlignment(tabPersonalInfo, (ErrorIconAlignment)resources.GetObject("tabPersonalInfo.IconAlignment"));
            errorProvider1.SetIconPadding(tabPersonalInfo, (int)resources.GetObject("tabPersonalInfo.IconPadding"));
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter2
            // 
            resources.ApplyResources(ctrlPersonCardWithFilter2, "ctrlPersonCardWithFilter2");
            errorProvider1.SetError(ctrlPersonCardWithFilter2, resources.GetString("ctrlPersonCardWithFilter2.Error"));
            ctrlPersonCardWithFilter2.FilterEnabled = true;
            errorProvider1.SetIconAlignment(ctrlPersonCardWithFilter2, (ErrorIconAlignment)resources.GetObject("ctrlPersonCardWithFilter2.IconAlignment"));
            errorProvider1.SetIconPadding(ctrlPersonCardWithFilter2, (int)resources.GetObject("ctrlPersonCardWithFilter2.IconPadding"));
            ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            ctrlPersonCardWithFilter2.ShowAddPerson = true;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.BackColor = Color.Transparent;
            btnNext.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnNext, resources.GetString("btnNext.Error"));
            btnNext.FlatAppearance.BorderSize = 2;
            errorProvider1.SetIconAlignment(btnNext, (ErrorIconAlignment)resources.GetObject("btnNext.IconAlignment"));
            errorProvider1.SetIconPadding(btnNext, (int)resources.GetObject("btnNext.IconPadding"));
            btnNext.Image = Properties.Resources.next;
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // tabLogin
            // 
            resources.ApplyResources(tabLogin, "tabLogin");
            tabLogin.BackColor = Color.White;
            tabLogin.Controls.Add(llUpdatePass);
            tabLogin.Controls.Add(pictureBox5);
            tabLogin.Controls.Add(chkActive);
            tabLogin.Controls.Add(label7);
            tabLogin.Controls.Add(btnConfirmPass);
            tabLogin.Controls.Add(btnPass);
            tabLogin.Controls.Add(txtConfirmPass);
            tabLogin.Controls.Add(txtPassword);
            tabLogin.Controls.Add(txtUserName);
            tabLogin.Controls.Add(pbConfirmPassword);
            tabLogin.Controls.Add(pictureBox3);
            tabLogin.Controls.Add(pictureBox2);
            tabLogin.Controls.Add(lblUserID);
            tabLogin.Controls.Add(pictureBox1);
            tabLogin.Controls.Add(lblConfirmPassword);
            tabLogin.Controls.Add(label4);
            tabLogin.Controls.Add(label3);
            tabLogin.Controls.Add(ctrlPersonCard1);
            tabLogin.Controls.Add(label2);
            errorProvider1.SetError(tabLogin, resources.GetString("tabLogin.Error"));
            errorProvider1.SetIconAlignment(tabLogin, (ErrorIconAlignment)resources.GetObject("tabLogin.IconAlignment"));
            errorProvider1.SetIconPadding(tabLogin, (int)resources.GetObject("tabLogin.IconPadding"));
            tabLogin.Name = "tabLogin";
            // 
            // llUpdatePass
            // 
            resources.ApplyResources(llUpdatePass, "llUpdatePass");
            errorProvider1.SetError(llUpdatePass, resources.GetString("llUpdatePass.Error"));
            errorProvider1.SetIconAlignment(llUpdatePass, (ErrorIconAlignment)resources.GetObject("llUpdatePass.IconAlignment"));
            errorProvider1.SetIconPadding(llUpdatePass, (int)resources.GetObject("llUpdatePass.IconPadding"));
            llUpdatePass.LinkColor = Color.Navy;
            llUpdatePass.Name = "llUpdatePass";
            llUpdatePass.TabStop = true;
            llUpdatePass.LinkClicked += llUpdatePass_LinkClicked;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            errorProvider1.SetError(pictureBox5, resources.GetString("pictureBox5.Error"));
            errorProvider1.SetIconAlignment(pictureBox5, (ErrorIconAlignment)resources.GetObject("pictureBox5.IconAlignment"));
            errorProvider1.SetIconPadding(pictureBox5, (int)resources.GetObject("pictureBox5.IconPadding"));
            pictureBox5.Image = Properties.Resources.active_user;
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // chkActive
            // 
            resources.ApplyResources(chkActive, "chkActive");
            errorProvider1.SetError(chkActive, resources.GetString("chkActive.Error"));
            errorProvider1.SetIconAlignment(chkActive, (ErrorIconAlignment)resources.GetObject("chkActive.IconAlignment"));
            errorProvider1.SetIconPadding(chkActive, (int)resources.GetObject("chkActive.IconPadding"));
            chkActive.Name = "chkActive";
            chkActive.UseVisualStyleBackColor = true;
            chkActive.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            errorProvider1.SetError(label7, resources.GetString("label7.Error"));
            errorProvider1.SetIconAlignment(label7, (ErrorIconAlignment)resources.GetObject("label7.IconAlignment"));
            errorProvider1.SetIconPadding(label7, (int)resources.GetObject("label7.IconPadding"));
            label7.Name = "label7";
            // 
            // btnConfirmPass
            // 
            resources.ApplyResources(btnConfirmPass, "btnConfirmPass");
            btnConfirmPass.BackColor = Color.Transparent;
            btnConfirmPass.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnConfirmPass, resources.GetString("btnConfirmPass.Error"));
            errorProvider1.SetIconAlignment(btnConfirmPass, (ErrorIconAlignment)resources.GetObject("btnConfirmPass.IconAlignment"));
            errorProvider1.SetIconPadding(btnConfirmPass, (int)resources.GetObject("btnConfirmPass.IconPadding"));
            btnConfirmPass.Image = Properties.Resources.hidden;
            btnConfirmPass.Name = "btnConfirmPass";
            btnConfirmPass.TabStop = false;
            btnConfirmPass.Tag = "0";
            btnConfirmPass.UseVisualStyleBackColor = false;
            btnConfirmPass.Click += btnConfirmPass_Click;
            // 
            // btnPass
            // 
            resources.ApplyResources(btnPass, "btnPass");
            btnPass.BackColor = Color.Transparent;
            btnPass.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnPass, resources.GetString("btnPass.Error"));
            errorProvider1.SetIconAlignment(btnPass, (ErrorIconAlignment)resources.GetObject("btnPass.IconAlignment"));
            errorProvider1.SetIconPadding(btnPass, (int)resources.GetObject("btnPass.IconPadding"));
            btnPass.Image = Properties.Resources.hidden;
            btnPass.Name = "btnPass";
            btnPass.TabStop = false;
            btnPass.Tag = "0";
            btnPass.UseVisualStyleBackColor = false;
            btnPass.Click += btnPass_Click;
            // 
            // txtConfirmPass
            // 
            resources.ApplyResources(txtConfirmPass, "txtConfirmPass");
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetError(txtConfirmPass, resources.GetString("txtConfirmPass.Error"));
            errorProvider1.SetIconAlignment(txtConfirmPass, (ErrorIconAlignment)resources.GetObject("txtConfirmPass.IconAlignment"));
            errorProvider1.SetIconPadding(txtConfirmPass, (int)resources.GetObject("txtConfirmPass.IconPadding"));
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.UseSystemPasswordChar = true;
            txtConfirmPass.Validating += txtConfirmPass_Validating;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetError(txtPassword, resources.GetString("txtPassword.Error"));
            errorProvider1.SetIconAlignment(txtPassword, (ErrorIconAlignment)resources.GetObject("txtPassword.IconAlignment"));
            errorProvider1.SetIconPadding(txtPassword, (int)resources.GetObject("txtPassword.IconPadding"));
            txtPassword.Name = "txtPassword";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUserName
            // 
            resources.ApplyResources(txtUserName, "txtUserName");
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetError(txtUserName, resources.GetString("txtUserName.Error"));
            errorProvider1.SetIconAlignment(txtUserName, (ErrorIconAlignment)resources.GetObject("txtUserName.IconAlignment"));
            errorProvider1.SetIconPadding(txtUserName, (int)resources.GetObject("txtUserName.IconPadding"));
            txtUserName.Name = "txtUserName";
            txtUserName.Validating += txtUserName_Validating;
            // 
            // pbConfirmPassword
            // 
            resources.ApplyResources(pbConfirmPassword, "pbConfirmPassword");
            errorProvider1.SetError(pbConfirmPassword, resources.GetString("pbConfirmPassword.Error"));
            errorProvider1.SetIconAlignment(pbConfirmPassword, (ErrorIconAlignment)resources.GetObject("pbConfirmPassword.IconAlignment"));
            errorProvider1.SetIconPadding(pbConfirmPassword, (int)resources.GetObject("pbConfirmPassword.IconPadding"));
            pbConfirmPassword.Image = Properties.Resources.password;
            pbConfirmPassword.Name = "pbConfirmPassword";
            pbConfirmPassword.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            errorProvider1.SetError(pictureBox3, resources.GetString("pictureBox3.Error"));
            errorProvider1.SetIconAlignment(pictureBox3, (ErrorIconAlignment)resources.GetObject("pictureBox3.IconAlignment"));
            errorProvider1.SetIconPadding(pictureBox3, (int)resources.GetObject("pictureBox3.IconPadding"));
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            errorProvider1.SetError(pictureBox2, resources.GetString("pictureBox2.Error"));
            errorProvider1.SetIconAlignment(pictureBox2, (ErrorIconAlignment)resources.GetObject("pictureBox2.IconAlignment"));
            errorProvider1.SetIconPadding(pictureBox2, (int)resources.GetObject("pictureBox2.IconPadding"));
            pictureBox2.Image = Properties.Resources.administrator;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // lblUserID
            // 
            resources.ApplyResources(lblUserID, "lblUserID");
            errorProvider1.SetError(lblUserID, resources.GetString("lblUserID.Error"));
            errorProvider1.SetIconAlignment(lblUserID, (ErrorIconAlignment)resources.GetObject("lblUserID.IconAlignment"));
            errorProvider1.SetIconPadding(lblUserID, (int)resources.GetObject("lblUserID.IconPadding"));
            lblUserID.Name = "lblUserID";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            errorProvider1.SetError(pictureBox1, resources.GetString("pictureBox1.Error"));
            errorProvider1.SetIconAlignment(pictureBox1, (ErrorIconAlignment)resources.GetObject("pictureBox1.IconAlignment"));
            errorProvider1.SetIconPadding(pictureBox1, (int)resources.GetObject("pictureBox1.IconPadding"));
            pictureBox1.Image = Properties.Resources.id__2_;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblConfirmPassword
            // 
            resources.ApplyResources(lblConfirmPassword, "lblConfirmPassword");
            errorProvider1.SetError(lblConfirmPassword, resources.GetString("lblConfirmPassword.Error"));
            errorProvider1.SetIconAlignment(lblConfirmPassword, (ErrorIconAlignment)resources.GetObject("lblConfirmPassword.IconAlignment"));
            errorProvider1.SetIconPadding(lblConfirmPassword, (int)resources.GetObject("lblConfirmPassword.IconPadding"));
            lblConfirmPassword.Name = "lblConfirmPassword";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            errorProvider1.SetError(label4, resources.GetString("label4.Error"));
            errorProvider1.SetIconAlignment(label4, (ErrorIconAlignment)resources.GetObject("label4.IconAlignment"));
            errorProvider1.SetIconPadding(label4, (int)resources.GetObject("label4.IconPadding"));
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            errorProvider1.SetError(label3, resources.GetString("label3.Error"));
            errorProvider1.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment"));
            errorProvider1.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding"));
            label3.Name = "label3";
            // 
            // ctrlPersonCard1
            // 
            resources.ApplyResources(ctrlPersonCard1, "ctrlPersonCard1");
            ctrlPersonCard1.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetError(ctrlPersonCard1, resources.GetString("ctrlPersonCard1.Error"));
            errorProvider1.SetIconAlignment(ctrlPersonCard1, (ErrorIconAlignment)resources.GetObject("ctrlPersonCard1.IconAlignment"));
            errorProvider1.SetIconPadding(ctrlPersonCard1, (int)resources.GetObject("ctrlPersonCard1.IconPadding"));
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.ShowUpdatePerson = false;
            ctrlPersonCard1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            errorProvider1.SetError(label2, resources.GetString("label2.Error"));
            errorProvider1.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment"));
            errorProvider1.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding"));
            label2.Name = "label2";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            errorProvider1.SetError(lblTitle, resources.GetString("lblTitle.Error"));
            lblTitle.ForeColor = Color.Brown;
            errorProvider1.SetIconAlignment(lblTitle, (ErrorIconAlignment)resources.GetObject("lblTitle.IconAlignment"));
            errorProvider1.SetIconPadding(lblTitle, (int)resources.GetObject("lblTitle.IconPadding"));
            lblTitle.Name = "lblTitle";
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = Color.Transparent;
            btnClose.CausesValidation = false;
            btnClose.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnClose, resources.GetString("btnClose.Error"));
            btnClose.FlatAppearance.BorderSize = 2;
            errorProvider1.SetIconAlignment(btnClose, (ErrorIconAlignment)resources.GetObject("btnClose.IconAlignment"));
            errorProvider1.SetIconPadding(btnClose, (int)resources.GetObject("btnClose.IconPadding"));
            btnClose.Image = Properties.Resources.cross;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            errorProvider1.SetError(btnSave, resources.GetString("btnSave.Error"));
            btnSave.FlatAppearance.BorderSize = 2;
            errorProvider1.SetIconAlignment(btnSave, (ErrorIconAlignment)resources.GetObject("btnSave.IconAlignment"));
            errorProvider1.SetIconPadding(btnSave, (int)resources.GetObject("btnSave.IconPadding"));
            btnSave.Image = Properties.Resources.favorite_15111499;
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // frmAdd_UpdateUser
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAdd_UpdateUser";
            ShowInTaskbar = false;
            Load += frmAdd_UpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tabPersonalInfo.ResumeLayout(false);
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPersonalInfo;
        private TabPage tabLogin;
        private Label lblTitle;
        private Button btnNext;
        private Button btnClose;
        private Button btnSave;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
        private ctrlPersonCard ctrlPersonCard1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblConfirmPassword;
        private Label label4;
        private Label label3;
        private TextBox txtConfirmPass;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private PictureBox pbConfirmPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblUserID;
        private ErrorProvider errorProvider1;
        private Button btnPass;
        private Button btnConfirmPass;
        private PictureBox pictureBox5;
        private CheckBox chkActive;
        private Label label7;
        private LinkLabel llUpdatePass;
    }
}