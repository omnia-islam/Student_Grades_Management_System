
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Student_Grades_Management_System.Data;

namespace Student_Grades_Management_System
{
    public partial class StudentsForm : Form
    {
        private bool isLoading = false;

        public StudentsForm()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;

            // Sidebar navigation
            btnDashboard.Click += btnDashboard_Click;
            btnGrades.Click += btnGrades_Click;
            btnCourses.Click += btnCourses_Click;
            btnReports.Click += btnReports_Click;
            btnLogout.Click += btnLogout_Click;

            txtStudentID.ReadOnly = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadDepartments();
            LoadStudents();
            ClearFields();
        }

        private void LoadDepartments()
        {
            cmbDepartment.Items.Clear();

            cmbDepartment.Items.Add("Computer Science");
            cmbDepartment.Items.Add("Information Systems");
            cmbDepartment.Items.Add("Information Technology");

            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            try
            {
                isLoading = true;

                string query = @"
                    SELECT StudentID, FullName, Email, Phone, Department
                    FROM Students
                    ORDER BY StudentID DESC";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStudents.AutoGenerateColumns = false;

                    dgvStudents.Columns["StudentID"].DataPropertyName = "StudentID";
                    dgvStudents.Columns["FullNameColumn"].DataPropertyName = "FullName";
                    dgvStudents.Columns["Email"].DataPropertyName = "Email";
                    dgvStudents.Columns["Phone"].DataPropertyName = "Phone";
                    dgvStudents.Columns["Department"].DataPropertyName = "Department";

                    dgvStudents.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load students:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading || dgvStudents.CurrentRow == null)
                return;

            DataGridViewRow row = dgvStudents.CurrentRow;

            if (row.IsNewRow || row.Cells["StudentID"].Value == null)
                return;

            txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
            txtFullName.Text = row.Cells["FullNameColumn"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";

            string department = row.Cells["Department"].Value?.ToString() ?? "";
            cmbDepartment.SelectedItem = department;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill in all student information.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                string query = @"
                    INSERT INTO Students
                    (FullName, Email, Phone, Department)
                    VALUES
                    (@FullName, @Email, @Phone, @Department)";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value =
                        txtFullName.Text.Trim();

                    command.Parameters.Add("@Email", SqlDbType.NVarChar, 150).Value =
                        txtEmail.Text.Trim();

                    command.Parameters.Add("@Phone", SqlDbType.NVarChar, 30).Value =
                        txtPhone.Text.Trim();

                    command.Parameters.Add("@Department", SqlDbType.NVarChar, 100).Value =
                        cmbDepartment.Text;

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Student added successfully!");

                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not add student:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                string query = @"
                    UPDATE Students
                    SET FullName = @FullName,
                        Email = @Email,
                        Phone = @Phone,
                        Department = @Department
                    WHERE StudentID = @StudentID";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value =
                        txtFullName.Text.Trim();

                    command.Parameters.Add("@Email", SqlDbType.NVarChar, 150).Value =
                        txtEmail.Text.Trim();

                    command.Parameters.Add("@Phone", SqlDbType.NVarChar, 30).Value =
                        txtPhone.Text.Trim();

                    command.Parameters.Add("@Department", SqlDbType.NVarChar, 100).Value =
                        cmbDepartment.Text;

                    command.Parameters.Add("@StudentID", SqlDbType.Int).Value =
                        Convert.ToInt32(txtStudentID.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Student updated successfully!");

                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not update student:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@StudentID", SqlDbType.Int).Value =
                        Convert.ToInt32(txtStudentID.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Student deleted successfully!");

                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete student. This student may have grades linked to their account.\n\n"
                    + ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;

                string query = @"
                    SELECT StudentID, FullName, Email, Phone, Department
                    FROM Students
                    WHERE FullName LIKE @Search
                       OR CONVERT(NVARCHAR(20), StudentID) LIKE @Search
                    ORDER BY StudentID DESC";

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@Search", SqlDbType.NVarChar, 200).Value =
                        "%" + txtSearch.Text.Trim() + "%";

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStudents.DataSource = table;
                }

                ClearFields();

                if (dgvStudents.Rows.Count == 0)
                    MessageBox.Show("No matching students found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed:\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dgvStudents.ClearSelection();
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbDepartment.SelectedIndex = -1;
        }

        // Navigation

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Close();
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
