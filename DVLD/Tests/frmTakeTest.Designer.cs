namespace DVLD
{
    partial class frmTakeTest
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
            ctrlSchedualedTest1 = new ctrlSchedualedTest();
            pictureBox7 = new PictureBox();
            lblResult = new Label();
            rbPassed = new RadioButton();
            rbFailed = new RadioButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtNotes = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            lblLockedTest = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlSchedualedTest1
            // 
            ctrlSchedualedTest1.Location = new Point(12, 1);
            ctrlSchedualedTest1.Name = "ctrlSchedualedTest1";
            ctrlSchedualedTest1.Size = new Size(692, 600);
            ctrlSchedualedTest1.TabIndex = 0;
            ctrlSchedualedTest1.TestType = DVLDBussinesLibary.clsTestTypes.enTestType.VisionTest;
            ctrlSchedualedTest1.Load += ctrlSchedualedTest1_Load;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.test_check;
            pictureBox7.Location = new Point(114, 607);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 52;
            pictureBox7.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 607);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(96, 28);
            lblResult.TabIndex = 51;
            lblResult.Text = "Result :";
            // 
            // rbPassed
            // 
            rbPassed.AutoSize = true;
            rbPassed.Font = new Font("Arial Black", 12F);
            rbPassed.Location = new Point(174, 610);
            rbPassed.Name = "rbPassed";
            rbPassed.Size = new Size(110, 32);
            rbPassed.TabIndex = 0;
            rbPassed.Text = "Passed";
            rbPassed.UseVisualStyleBackColor = true;
            // 
            // rbFailed
            // 
            rbFailed.AutoSize = true;
            rbFailed.Checked = true;
            rbFailed.Font = new Font("Arial Black", 12F);
            rbFailed.Location = new Point(299, 610);
            rbFailed.Name = "rbFailed";
            rbFailed.Size = new Size(98, 32);
            rbFailed.TabIndex = 1;
            rbFailed.TabStop = true;
            rbFailed.Text = "Failed";
            rbFailed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 673);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 55;
            label1.Text = "Notes :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.documents;
            pictureBox1.Location = new Point(114, 673);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(174, 683);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(412, 101);
            txtNotes.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(361, 798);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 44);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Black", 10F);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.Location = new Point(495, 798);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblLockedTest
            // 
            lblLockedTest.AutoSize = true;
            lblLockedTest.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLockedTest.ForeColor = Color.Red;
            lblLockedTest.Location = new Point(127, 194);
            lblLockedTest.Name = "lblLockedTest";
            lblLockedTest.Size = new Size(452, 24);
            lblLockedTest.TabIndex = 57;
            lblLockedTest.Text = "Person Already Sat For the test, Results Locked";
            lblLockedTest.Visible = false;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(706, 853);
            Controls.Add(lblLockedTest);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtNotes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(rbFailed);
            Controls.Add(rbPassed);
            Controls.Add(pictureBox7);
            Controls.Add(lblResult);
            Controls.Add(ctrlSchedualedTest1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmTakeTest";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take Test";
            Load += frmTakeTest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlSchedualedTest ctrlSchedualedTest1;
        private PictureBox pictureBox7;
        private Label lblResult;
        private RadioButton rbPassed;
        private RadioButton rbFailed;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtNotes;
        private Button btnClose;
        private Button btnSave;
        private Label lblLockedTest;
    }
}