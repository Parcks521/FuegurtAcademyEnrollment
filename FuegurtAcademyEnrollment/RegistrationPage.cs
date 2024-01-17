using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace FuegurtAcademyEnrollment
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void RegistrationPage_Load(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" || txtStudName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtNumber.Text == "" || cmbCourse.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Fill all the information needed! ");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Students_Table (SStudent_ID, SStudent_Name, SAge, SEmail, SPhoneNum, SCourse) VALUES (@StudentId, @StudentName, @Age, @Email, @Number, @Course)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@StudentId", txtStudentID.Text);
                    cmd.Parameters.AddWithValue("@StudentName", txtStudName.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Number", txtNumber.Text);
                    cmd.Parameters.AddWithValue("@Course", cmbCourse.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Successfully Enrolled");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
            cmbCourse.SelectedItem = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SchoolPage school = new SchoolPage();
            school.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
