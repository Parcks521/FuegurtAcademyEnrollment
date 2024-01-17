using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuegurtAcademyEnrollment
{
    public partial class SchoolPage : Form
    {
        public SchoolPage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            RegistrationPage registration = new RegistrationPage();
            registration.Show();
            this.Hide();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            UpdateStudent update = new UpdateStudent();
            update.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
