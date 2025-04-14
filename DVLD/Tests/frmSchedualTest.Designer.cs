namespace DVLD
{
    partial class frmSchedualTest
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
            btnClose = new Button();
            ctrlScheduleTest1 = new ctrlScheduleTest();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Black", 10F);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.Location = new Point(467, 723);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 44);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ctrlScheduleTest1.Location = new Point(1, 11);
            ctrlScheduleTest1.Margin = new Padding(5, 4, 5, 4);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(714, 770);
            ctrlScheduleTest1.TabIndex = 37;
            ctrlScheduleTest1.TestType = DVLDBussinesLibary.clsTestTypes.enTestType.VisionTest;
            ctrlScheduleTest1.Load += ctrlScheduleTest1_Load;
            // 
            // frmSchedualTest
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 772);
            Controls.Add(btnClose);
            Controls.Add(ctrlScheduleTest1);
            Font = new Font("Arial Black", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 4, 6, 4);
            Name = "frmSchedualTest";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedual Test";
            Load += frmSchedualTest_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnClose;
        private ctrlScheduleTest ctrlScheduleTest1;
    }
}