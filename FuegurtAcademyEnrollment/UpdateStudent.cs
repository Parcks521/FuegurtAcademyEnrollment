using System.Data;
using System.Data.SqlClient;

namespace FuegurtAcademyEnrollment
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30");
        int dan = 0;
        private void btnBack_Click(object sender, EventArgs e)
        {
            SchoolPage school = new SchoolPage();
            school.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dan == 0 || txtStudentID.Text == "" || txtStudName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtNumber.Text == "" || cmbCourse.Text == "")
            {
                MessageBox.Show("Please select information to change!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    string query = "UPDATE Students_Table SET SStudent_ID = '" + txtStudentID.Text + "', SStudent_Name = '" + txtStudName.Text + "', SAge = '" + txtAge.Text + "', SEmail = '" + txtEmail.Text + "', SPhoneNum = '" + txtNumber.Text + "', SCourse = '" + cmbCourse.Text + "' WHERE ID = " + dan;
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Student's Information is Successfully Updated!");
                    populate();
                }
            }

        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridStudents.Rows[e.RowIndex];
                dan = Convert.ToInt32(selectedRow.Cells[0].Value?.ToString() ?? "");
                txtStudentID.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                txtStudName.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtAge.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                txtEmail.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                txtNumber.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                cmbCourse.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
            }
        }
        private void populate()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                string query = "select * from Students_Table";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    var resultDataSet = new DataSet();
                    adapter.Fill(resultDataSet);
                    using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                    {
                        dataGridStudents.DataSource = resultDataSet.Tables[0];
                    }
                }
            }

        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            populate();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dan == 0)
            {
                MessageBox.Show("Select a Student to be deleted!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    string query = "DELETE FROM Students_Table WHERE ID = " + dan;
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Student Successfully Deleted!");
                    populate();
                }
            }

        }

        private void btnSearchStud_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text.Trim() != "")
            {
                string searchQuery = "SELECT * FROM Students_Table WHERE SStudent_Name LIKE @searchTerm";

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + txtSearch1.Text.Trim() + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            var resultDataSet = new DataSet();
                            adapter.Fill(resultDataSet);

                            if (resultDataSet.Tables[0].Rows.Count > 0)
                            {
                                dataGridStudents.DataSource = resultDataSet.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No record found for this student.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter something to search.", "Search Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSearchCourses_Click(object sender, EventArgs e)
        {
            if (txtSearch2.Text.Trim() != "")
            {
                string searchQuery = "SELECT * FROM Students_Table WHERE SCourse LIKE @searchCourse";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@searchCourse", "%" + txtSearch2.Text.Trim() + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            var resultDataSet = new DataSet();
                            adapter.Fill(resultDataSet);

                            if (resultDataSet.Tables[0].Rows.Count > 0)
                            {
                                dataGridStudents.DataSource = resultDataSet.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No record found for this Course!.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter something to search.", "Search Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\studentsDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string viewQuery = "SELECT * FROM Students_Table";

                    using (SqlCommand cmd = new SqlCommand(viewQuery, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            var resultDataSet = new DataSet();
                            adapter.Fill(resultDataSet);

                            if (resultDataSet.Tables[0].Rows.Count > 0)
                            {
                                dataGridStudents.DataSource = resultDataSet.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No records found.", "Empty Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearr_Click(object sender, EventArgs e)
        {
            if (txtSearch1.Text == "")
            {
                MessageBox.Show("Nothing to be Cleared");
            }
            else
            {
                txtSearch1.Text = "";
                MessageBox.Show("Successfully Cleared");

            }
        }

        private void btnClearrr_Click(object sender, EventArgs e)
        {
            if (txtSearch2.Text == "")
            {
                MessageBox.Show("Nothing to be Cleared");
            }
            else
            {
                txtSearch2.Text = "";
                MessageBox.Show("Successfully Cleared");

            }



        }
    }
}
