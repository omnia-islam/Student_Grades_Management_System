
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Grades_Management_System.Data;

namespace Student_Grades_Management_System
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Load dashboard data
            this.Load -= DashboardForm_Load;
            this.Load += DashboardForm_Load;

            // Sidebar navigation
            btnStudents.Click += btnStudents_Click;
            btnGrades.Click += btnGrades_Click;
            btnCourses.Click += btnCourses_Click;
            btnReports.Click += btnReports_Click;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        // Open Students Form
        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (StudentsForm studentsForm = new StudentsForm())
            {
                studentsForm.ShowDialog(this);
            }

            this.Show();
        }

        // Open Grades Form
        private void btnGrades_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (GradesForm gradesForm = new GradesForm())
            {
                gradesForm.ShowDialog(this);
            }

            this.Show();
        }

        // Open Courses Form
        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Courses coursesForm = new Courses())
            {
                coursesForm.ShowDialog(this);
            }

            this.Show();
        }

        // Open Reports Form
        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Reports reportsForm = new Reports())
            {
                reportsForm.ShowDialog(this);
            }

            this.Show();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    if (connection.Database != "StudentGradesDB")
                    {
                        MessageBox.Show(
                            "The application is connected to the wrong database: "
                            + connection.Database,
                            "Database Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    LoadStatistics(connection);
                    LoadRecentGrades(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Dashboard data could not be loaded.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Load statistics cards
        private void LoadStatistics(SqlConnection connection)
        {
            string query = @"
                SELECT
                    (SELECT COUNT(*) FROM Students) AS TotalStudents,
                    (SELECT COUNT(*) FROM Courses) AS TotalCourses,
                    (SELECT COUNT(*) FROM Grades) AS TotalGrades,
                    (
                        SELECT AVG(
                            CASE
                                WHEN Score >= 90 THEN 4.0
                                WHEN Score >= 85 THEN 3.7
                                WHEN Score >= 80 THEN 3.3
                                WHEN Score >= 75 THEN 3.0
                                WHEN Score >= 70 THEN 2.7
                                WHEN Score >= 65 THEN 2.4
                                WHEN Score >= 60 THEN 2.0
                                WHEN Score >= 50 THEN 1.0
                                ELSE 0.0
                            END
                        )
                        FROM Grades
                    ) AS AverageGPA;";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    lblStudentsCount.Text =
                        Convert.ToString(reader["TotalStudents"]);

                    lblCoursesCount.Text =
                        Convert.ToString(reader["TotalCourses"]);

                    lblGradesCount.Text =
                        Convert.ToString(reader["TotalGrades"]);

                    lblAverageGPA.Text =
                        reader["AverageGPA"] == DBNull.Value
                        ? "0.00"
                        : Convert.ToDecimal(reader["AverageGPA"]).ToString("0.00");
                }
            }
        }

        // Load the latest 10 grades
        private void LoadRecentGrades(SqlConnection connection)
        {
            string query = @"
                SELECT TOP 10
                    S.FullName AS StudentName,
                    C.CourseName,
                    G.Score,
                    G.LetterGrade,
                    G.Status
                FROM Grades G
                INNER JOIN Students S
                    ON G.StudentID = S.StudentID
                INNER JOIN Courses C
                    ON G.CourseID = C.CourseID
                ORDER BY G.GradeID DESC;";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (dgvRecentGrades.Columns.Count > 0)
                {
                    dgvRecentGrades.AutoGenerateColumns = false;

                    string[] fieldNames =
                    {
                        "StudentName",
                        "CourseName",
                        "Score",
                        "LetterGrade",
                        "Status"
                    };

                    int count = Math.Min(
                        dgvRecentGrades.Columns.Count,
                        fieldNames.Length
                    );

                    for (int i = 0; i < count; i++)
                    {
                        dgvRecentGrades.Columns[i].DataPropertyName =
                            fieldNames[i];
                    }
                }
                else
                {
                    dgvRecentGrades.AutoGenerateColumns = true;
                }

                dgvRecentGrades.DataSource = null;
                dgvRecentGrades.DataSource = table;

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "The database is connected, but the Grades table has no matching records.",
                        "No Grades Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void lblStudentsTitle_Click(object sender, EventArgs e) { }
        private void pnlGPACard_Paint(object sender, PaintEventArgs e) { }
    }
}
