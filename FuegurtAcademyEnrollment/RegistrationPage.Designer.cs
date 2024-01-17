namespace FuegurtAcademyEnrollment
{
    partial class RegistrationPage
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            panel3 = new Panel();
            cmbCourse = new ComboBox();
            btnClear = new Button();
            btnEnroll = new Button();
            txtNumber = new RichTextBox();
            txtEmail = new RichTextBox();
            txtAge = new RichTextBox();
            txtStudName = new RichTextBox();
            txtStudentID = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 115);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.F_U_removebg_preview;
            pictureBox2.Location = new Point(844, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 105);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.F_U_removebg_preview;
            pictureBox1.Location = new Point(287, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 105);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Limelight", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(382, 31);
            label1.Name = "label1";
            label1.Size = new Size(471, 59);
            label1.TabIndex = 0;
            label1.Text = "Enrollment Page";
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnBack);
            panel2.Location = new Point(1, 691);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 115);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(19, 41);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(157, 46);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(cmbCourse);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnEnroll);
            panel3.Controls.Add(txtNumber);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtAge);
            panel3.Controls.Add(txtStudName);
            panel3.Controls.Add(txtStudentID);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(604, 545);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science", "Bachelor of Science in Computer Engineering", "Bachelor of Science in Nursing", "Bachelor of Science in Accountancy", "Bachelor of Science in Nutrition" });
            cmbCourse.Location = new Point(168, 384);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(284, 23);
            cmbCourse.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(357, 459);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 46);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnroll.Location = new Point(108, 459);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(157, 46);
            btnEnroll.TabIndex = 12;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(170, 308);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(282, 38);
            txtNumber.TabIndex = 10;
            txtNumber.Text = "";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 38);
            txtEmail.TabIndex = 9;
            txtEmail.Text = "";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(170, 188);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(282, 38);
            txtAge.TabIndex = 8;
            txtAge.Text = "";
            // 
            // txtStudName
            // 
            txtStudName.Location = new Point(170, 131);
            txtStudName.Name = "txtStudName";
            txtStudName.Size = new Size(282, 38);
            txtStudName.TabIndex = 7;
            txtStudName.Text = "";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(170, 78);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(282, 38);
            txtStudentID.TabIndex = 6;
            txtStudentID.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(58, 387);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 5;
            label7.Text = "Course";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(58, 327);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 4;
            label6.Text = "Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 266);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 206);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 149);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 1;
            label3.Text = "StudentName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 96);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "StudentID";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.asdasdasdasdazdasdsdsdsds;
            pictureBox3.Location = new Point(688, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(499, 334);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1244, 805);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrationPage";
            Text = "RegistrationPage";
            Load += RegistrationPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnClear;
        private Button btnEnroll;
        private RichTextBox txtNumber;
        private RichTextBox txtEmail;
        private RichTextBox txtAge;
        private RichTextBox txtStudName;
        private RichTextBox txtStudentID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbCourse;
        private Button btnBack;
        private PictureBox pictureBox3;
    }
}