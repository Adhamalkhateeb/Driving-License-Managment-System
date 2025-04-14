namespace DVLD
{
    partial class frmUpdateTestTypes
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
            txtFees = new TextBox();
            txtTitle = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTestTypeID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtDescription = new TextBox();
            pictureBox3 = new PictureBox();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtFees
            // 
            txtFees.BorderStyle = BorderStyle.FixedSingle;
            txtFees.Location = new Point(292, 354);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(403, 36);
            txtFees.TabIndex = 9;
            txtFees.KeyPress += txtFees_KeyPress;
            txtFees.Validating += txtFees_Validating;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(292, 154);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(403, 36);
            txtTitle.TabIndex = 8;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(209, 352);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ApplicationTitle;
            pictureBox1.Location = new Point(209, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Location = new Point(292, 91);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(76, 28);
            lblTestTypeID.TabIndex = 14;
            lblTestTypeID.Text = "[????]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 352);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 13;
            label4.Text = "Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 153);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 12;
            label3.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 11;
            label2.Text = "ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 42);
            label1.TabIndex = 10;
            label1.Text = "Update Test Types";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 227);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 17;
            label5.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(292, 225);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(403, 99);
            txtDescription.TabIndex = 18;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ApplicationTitle;
            pictureBox3.Location = new Point(209, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Black", 10F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(597, 429);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 62);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CausesValidation = false;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(441, 429);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 62);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUpdateTestTypes
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(750, 514);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(pictureBox3);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTestTypeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmUpdateTestTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Test Types";
            Load += frmUpdateTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFees;
        private TextBox txtTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblTestTypeID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtDescription;
        private PictureBox pictureBox3;
        private Button btnSave;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}