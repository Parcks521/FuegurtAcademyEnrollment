namespace FuegurtAcademyEnrollment
{
    partial class SchoolPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolPage));
            btnLogout = new Button();
            panel2 = new Panel();
            btnUpdateDelete = new Button();
            btnAddStudent = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(19, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 46);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnUpdateDelete);
            panel2.Controls.Add(btnAddStudent);
            panel2.Location = new Point(2, 689);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 115);
            panel2.TabIndex = 5;
            // 
            // btnUpdateDelete
            // 
            btnUpdateDelete.BackColor = Color.Transparent;
            btnUpdateDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateDelete.Location = new Point(836, 41);
            btnUpdateDelete.Name = "btnUpdateDelete";
            btnUpdateDelete.Size = new Size(301, 46);
            btnUpdateDelete.TabIndex = 17;
            btnUpdateDelete.Text = "Update Student Information";
            btnUpdateDelete.UseVisualStyleBackColor = false;
            btnUpdateDelete.Click += btnUpdateDelete_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.Transparent;
            btnAddStudent.BackgroundImageLayout = ImageLayout.None;
            btnAddStudent.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.Location = new Point(343, 41);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(301, 46);
            btnAddStudent.TabIndex = 16;
            btnAddStudent.Text = "Enrollment";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Limelight", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(371, 31);
            label1.Name = "label1";
            label1.Size = new Size(513, 59);
            label1.TabIndex = 0;
            label1.Text = "Fuegurt University";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.F_U_removebg_preview;
            pictureBox1.Location = new Point(276, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 105);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 115);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.F_U_removebg_preview;
            pictureBox2.Location = new Point(885, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 105);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(1057, 480);
            label2.TabIndex = 8;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // SchoolPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 805);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SchoolPage";
            Text = "SchoolPage";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Panel panel2;
        private Button btnUpdateDelete;
        private Button btnAddStudent;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}