
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Grades_Management_System.Data;

namespace Student_Grades_Management_System
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();

            btnDashboard.Click += btnDashboard_Click;
            btnStudents.Click += btnStudents_Click;
            btnGrades.Click += btnGrades_Click;
            btnReports.Click += btnReports_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT
                            CourseID,
                            CourseCode,
                            CourseName,
                            CreditHours
                        FROM Courses
                        ORDER BY CourseID;";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvCourses.AutoGenerateColumns = true;
                        dgvCourses.DataSource = dt;

                        dgvCourses.ReadOnly = true;
                        dgvCourses.AllowUserToAddRows = false;
                        dgvCourses.AllowUserToDeleteRows = false;
                        dgvCourses.SelectionMode =
                            DataGridViewSelectionMode.FullRowSelect;
                        dgvCourses.MultiSelect = false;
                        dgvCourses.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                        dgvCourses.RowHeadersVisible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading courses from database:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Navigation

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Hide();

            using (StudentsForm form = new StudentsForm())
            {
                form.ShowDialog(this);
            }

            Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Hide();

            using (GradesForm form = new GradesForm())
            {
                form.ShowDialog(this);
            }

            Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Hide();

            using (Reports form = new Reports())
            {
                form.ShowDialog(this);
            }

            Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
