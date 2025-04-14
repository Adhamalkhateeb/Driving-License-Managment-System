namespace DVLD
{
    partial class frmUpdateApplicationType
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblApplicationTypeID = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtTitle = new TextBox();
            txtFees = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(438, 42);
            label1.TabIndex = 1;
            label1.Text = "Update Application Types";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 99);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 2;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 155);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 3;
            label3.Text = "Title :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 216);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 4;
            label4.Text = "Fees :";
            // 
            // lblApplicationTypeID
            // 
            lblApplicationTypeID.AutoSize = true;
            lblApplicationTypeID.Location = new Point(220, 99);
            lblApplicationTypeID.Name = "lblApplicationTypeID";
            lblApplicationTypeID.Size = new Size(76, 28);
            lblApplicationTypeID.TabIndex = 5;
            lblApplicationTypeID.Text = "[????]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ApplicationTitle;
            pictureBox1.Location = new Point(142, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(142, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(220, 159);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(458, 36);
            txtTitle.TabIndex = 0;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // txtFees
            // 
            txtFees.BorderStyle = BorderStyle.FixedSingle;
            txtFees.Location = new Point(220, 220);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(458, 36);
            txtFees.TabIndex = 1;
            txtFees.KeyPress += txtFees_KeyPress;
            txtFees.Validating += txtFees_Validating;
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
            btnClose.Location = new Point(422, 291);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 49);
            btnClose.TabIndex = 3;
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
            btnSave.Font = new Font("Arial Black", 10F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(565, 291);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 49);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUpdateApplicationType
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(720, 351);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblApplicationTypeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmUpdateApplicationType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Application Type";
            Load += frmUpdateApplicationType_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblApplicationTypeID;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtTitle;
        private TextBox txtFees;
        private Button btnClose;
        private Button btnSave;
        private ErrorProvider errorProvider1;
    }
}