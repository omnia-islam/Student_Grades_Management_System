
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Grades_Management_System.Data;

namespace Student_Grades_Management_System
{
    public partial class GradesForm : Form
    {
        private ComboBox cmbCourseFilter;
        private Label lblFilterCourse;
        private bool isLoadingCourses = false;

        public GradesForm()
        {
            InitializeComponent();

            AddCourseFilter();

            btnSearch.Click += btnSearch_Click;

            cmbCourseFilter.SelectedIndexChanged +=
                cmbCourseFilter_SelectedIndexChanged;

            btnDashboard.Click += btnDashboard_Click;
            btnStudents.Click += btnStudents_Click;
            btnCourses.Click += btnCourses_Click;
            btnReports.Click += btnReports_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void AddCourseFilter()
        {
            lblFilterCourse = new Label
            {
                Name = "lblFilterCourse",
                Text = "Course:",
                Location = new Point(225, 91),
                Size = new Size(60, 25),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.Navy,
                TextAlign = ContentAlignment.MiddleLeft
            };

            cmbCourseFilter = new ComboBox
            {
                Name = "cmbCourseFilter",
                Location = new Point(285, 88),
                Size = new Size(260, 32),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                ForeColor = Color.Navy
            };

            Controls.Add(lblFilterCourse);
            Controls.Add(cmbCourseFilter);

            lblFilterCourse.BringToFront();
            cmbCourseFilter.BringToFront();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadGrades();
        }

        // Load courses from database
        private void LoadCourses()
        {
            try
            {
                isLoadingCourses = true;

                using SqlConnection connection =
                    DatabaseConnection.GetConnection();

                string query = @"
                    SELECT CourseID, CourseName
                    FROM Courses
                    ORDER BY CourseCode;";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                DataRow allRow = table.NewRow();
                allRow["CourseID"] = 0;
                allRow["CourseName"] = "All Courses";

                table.Rows.InsertAt(allRow, 0);

                cmbCourseFilter.DataSource = table;
                cmbCourseFilter.DisplayMember = "CourseName";
                cmbCourseFilter.ValueMember = "CourseID";
                cmbCourseFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load courses:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                isLoadingCourses = false;
            }
        }

        // Get selected course ID
        private int? GetSelectedCourseID()
        {
            if (cmbCourseFilter.SelectedValue == null)
                return null;

            if (int.TryParse(
                cmbCourseFilter.SelectedValue.ToString(),
                out int courseID))
            {
                return courseID == 0 ? null : courseID;
            }

            return null;
        }

        // Load grades from database
        private void LoadGrades(string searchText = "")
        {
            try
            {
                string query = @"
                    SELECT
                        G.GradeID,
                        G.StudentID,
                        C.CourseName,
                        G.Score,
                        G.LetterGrade,
                        G.Status
                    FROM Grades G
                    INNER JOIN Students S
                        ON G.StudentID = S.StudentID
                    INNER JOIN Courses C
                        ON G.CourseID = C.CourseID
                    WHERE
                        (@CourseID IS NULL OR G.CourseID = @CourseID)
                        AND
                        (
                            CAST(G.GradeID AS NVARCHAR(20)) LIKE @Search
                            OR CAST(G.StudentID AS NVARCHAR(20)) LIKE @Search
                            OR S.FullName LIKE @Search
                            OR C.CourseName LIKE @Search
                            OR G.LetterGrade LIKE @Search
                            OR G.Status LIKE @Search
                            OR CAST(G.Score AS NVARCHAR(20)) LIKE @Search
                        )
                    ORDER BY G.GradeID;";

                using SqlConnection connection =
                    DatabaseConnection.GetConnection();

                using SqlCommand command =
                    new SqlCommand(query, connection);

                int? courseID = GetSelectedCourseID();

                command.Parameters.Add("@CourseID", SqlDbType.Int).Value =
                    courseID.HasValue
                        ? courseID.Value
                        : DBNull.Value;

                command.Parameters.Add(
                    "@Search",
                    SqlDbType.NVarChar,
                    100
                ).Value = "%" + searchText.Trim() + "%";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                // Use the existing Designer columns
                dgvGrades.AutoGenerateColumns = false;

                GradeID.DataPropertyName = "GradeID";
                StudentID.DataPropertyName = "StudentID";
                CourseName.DataPropertyName = "CourseName";
                Score.DataPropertyName = "Score";
                LetterGrade.DataPropertyName = "LetterGrade";
                Status.DataPropertyName = "Status";

                dgvGrades.DataSource = null;
                dgvGrades.DataSource = table;

                dgvGrades.Columns["GradeID"].HeaderText = "Grade ID";
                dgvGrades.Columns["StudentID"].HeaderText = "Student ID";
                dgvGrades.Columns["CourseName"].HeaderText = "Course Name";
                dgvGrades.Columns["Score"].HeaderText = "Score";
                dgvGrades.Columns["LetterGrade"].HeaderText = "Letter Grade";
                dgvGrades.Columns["Status"].HeaderText = "Status";

                dgvGrades.Columns["Score"].DefaultCellStyle.Format = "0.00";

                dgvGrades.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvGrades.ReadOnly = true;
                dgvGrades.AllowUserToAddRows = false;
                dgvGrades.AllowUserToDeleteRows = false;
                dgvGrades.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvGrades.RowHeadersVisible = false;
                dgvGrades.RowTemplate.Height = 35;

                dgvGrades.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 9F, FontStyle.Bold);

                dgvGrades.DefaultCellStyle.Font =
                    new Font("Segoe UI", 9F);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load grades:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGrades(txtSearchBar.Text);
        }

        private void cmbCourseFilter_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (!isLoadingCourses && IsHandleCreated)
            {
                LoadGrades(txtSearchBar.Text);
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

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Hide();

            using (Courses form = new Courses())
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
