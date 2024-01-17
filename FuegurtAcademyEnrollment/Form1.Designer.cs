namespace FuegurtAcademyEnrollment
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtLoginUser = new RichTextBox();
            txtLoginPass = new RichTextBox();
            btnLogin = new Button();
            btnReset = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Image = Properties.Resources.F_U_removebg_preview;
            pictureBox1.Location = new Point(343, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 105);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtLoginUser
            // 
            txtLoginUser.BackColor = Color.FromArgb(224, 224, 224);
            txtLoginUser.Location = new Point(25, 54);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.ShowSelectionMargin = true;
            txtLoginUser.Size = new Size(251, 36);
            txtLoginUser.TabIndex = 3;
            txtLoginUser.Text = "";
            // 
            // txtLoginPass
            // 
            txtLoginPass.BackColor = Color.FromArgb(224, 224, 224);
            txtLoginPass.Location = new Point(25, 142);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(251, 36);
            txtLoginPass.TabIndex = 4;
            txtLoginPass.Text = "";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(25, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 38);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(154, 198);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 38);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtLoginPass);
            panel1.Controls.Add(txtLoginUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 273);
            panel1.TabIndex = 7;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(554, 331);
            Controls.Add(panel1);
            Name = "loginPage";
            Text = "Login Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RichTextBox txtLoginUser;
        private RichTextBox txtLoginPass;
        private Button btnLogin;
        private Button btnReset;
        private Panel panel1;
    }
}