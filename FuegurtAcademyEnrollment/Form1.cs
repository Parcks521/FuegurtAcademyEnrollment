namespace FuegurtAcademyEnrollment
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            EnablePasswordMasking();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == "" || txtLoginPass.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password! ");
            }
            else if (txtLoginUser.Text == "Admin" || txtLoginPass.Text == "12345")
            {
                SchoolPage school = new SchoolPage();
                school.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }
        private void EnablePasswordMasking()
        {
            txtLoginPass.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar))
                {     
                    txtLoginPass.AppendText("*");
                    e.Handled = true; 
                }
            };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLoginUser.Text = "";
            txtLoginPass.Text = "";
        }
    }
}