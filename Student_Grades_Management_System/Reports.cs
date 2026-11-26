
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel;
using Student_Grades_Management_System.Data;

namespace Student_Grades_Management_System
{
    public partial class Reports : Form
    {
        private TabControl tabCourses;
        private Button btnExportExcel;
        private DataTable coursesTable;

        public Reports()
        {
            InitializeComponent();

            SetupReportsLayout();

            btnDashboard.Click += btnDashboard_Click;
            btnStudents.Click += btnStudents_Click;
            btnCourses.Click += btnCourses_Click;
            btnGrades.Click += btnGrades_Click;
            btnLogout.Click += btnLogout_Click;

            btnRefresh.Click += btnRefresh_Click;
            btnExportExcel.Click += btnExportExcel_Click;
        }

        // Prepare Reports Layout
        private void SetupReportsLayout()
        {
            dgvReports.Visible = false;

            lblReportsTitle.Text = "Course Performance Reports";
            lblReportsTitle.Location = new Point(7, 16);
            lblReportsTitle.Size = new Size(500, 50);
            lblReportsTitle.Font =
                new Font("Segoe UI", 13F, FontStyle.Bold);
            lblReportsTitle.ForeColor = Color.Navy;

            btnRefresh.Text = "Refresh";
            btnRefresh.Location = new Point(675, 22);
            btnRefresh.Size = new Size(112, 40);
            btnRefresh.BackColor = Color.Navy;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;

            btnExportExcel = new Button
            {
                Name = "btnExportExcel",
                Text = "Export Excel",
                Location = new Point(535, 22),
                Size = new Size(125, 40),
                BackColor = Color.FromArgb(35, 120, 80),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnExportExcel.FlatAppearance.BorderSize = 0;

            tabCourses = new TabControl
            {
                Name = "tabCourses",
                Location = new Point(12, 78),
                Size = new Size(785, 310),
                Font = new Font("Segoe UI", 9F),
                ItemSize = new Size(100, 30),
                SizeMode = TabSizeMode.Normal,
                Anchor = AnchorStyles.Top |
                         AnchorStyles.Bottom |
                         AnchorStyles.Left |
                         AnchorStyles.Right
            };

            pnlReportsTable.Controls.Add(btnExportExcel);
            pnlReportsTable.Controls.Add(tabCourses);

            btnExportExcel.BringToFront();
            btnRefresh.BringToFront();
            lblReportsTitle.BringToFront();
        }

        // Form Load
        private void Reports_Load(object sender, EventArgs e)
        {
            LoadReportStatistics();
            LoadCourseReports();
        }

        // Load General Statistics
        private void LoadReportStatistics()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseConnection.GetConnection();

                connection.Open();

                string query = @"
                    SELECT
                        (SELECT COUNT(*) FROM Students) AS TotalStudents,
                        (SELECT COUNT(*) FROM Courses) AS TotalCourses,
                        (SELECT COUNT(*) FROM Grades) AS TotalGrades,
                        (SELECT ISNULL(AVG(Score), 0)
                         FROM Grades) AS AverageScore;";

                using SqlCommand command =
                    new SqlCommand(query, connection);

                using SqlDataReader reader =
                    command.ExecuteReader();

                if (reader.Read())
                {
                    lblStudentTitle.Text =
                        reader["TotalStudents"].ToString();

                    lblCoursesTitle.Text =
                        reader["TotalCourses"].ToString();

                    lblGradesTitle.Text =
                        reader["TotalGrades"].ToString();

                    lblAverageTitle.Text =
                        Convert.ToDecimal(reader["AverageScore"])
                        .ToString("0.00") + "%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load statistics:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Load All Course Reports
        private void LoadCourseReports()
        {
            try
            {
                using SqlConnection connection =
                    DatabaseConnection.GetConnection();

                string query = @"
                    SELECT CourseID, CourseCode, CourseName
                    FROM Courses
                    ORDER BY CourseCode;";

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection);

                coursesTable = new DataTable();
                adapter.Fill(coursesTable);

                tabCourses.TabPages.Clear();

                foreach (DataRow course in coursesTable.Rows)
                {
                    int courseID =
                        Convert.ToInt32(course["CourseID"]);

                    string courseCode =
                        Convert.ToString(course["CourseCode"]) ?? "";

                    string courseName =
                        Convert.ToString(course["CourseName"]) ?? "";

                    TabPage page = new TabPage
                    {
                        Text = courseCode,
                        BackColor = Color.White,
                        Tag = courseID
                    };

                    CreateCourseReport(
                        page,
                        courseID,
                        courseName);

                    tabCourses.TabPages.Add(page);
                }

                if (coursesTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No courses were found in the database.",
                        "Reports",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load course reports:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Create One Course Report
        private void CreateCourseReport(
            TabPage page,
            int courseID,
            string courseName)
        {
            DataTable grades = LoadCourseGrades(courseID);

            int total = grades.Rows.Count;
            int passed = 0;
            int failed = 0;

            foreach (DataRow row in grades.Rows)
            {
                string status =
                    Convert.ToString(row["Status"]) ?? "";

                if (string.Equals(
                    status,
                    "Passed",
                    StringComparison.OrdinalIgnoreCase))
                {
                    passed++;
                }
                else if (string.Equals(
                    status,
                    "Failed",
                    StringComparison.OrdinalIgnoreCase))
                {
                    failed++;
                }
            }

            double passRate =
                total == 0 ? 0 : passed * 100.0 / total;

            double failRate =
                total == 0 ? 0 : failed * 100.0 / total;

            Label lblCourseName = new Label
            {
                Text = courseName,
                Location = new Point(12, 8),
                Size = new Size(740, 26),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.Navy
            };

            Label lblPassed = new Label
            {
                Text = $"Passed: {passed} ({passRate:0.0}%)",
                Location = new Point(15, 38),
                Size = new Size(220, 25),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 130, 75)
            };

            Label lblFailed = new Label
            {
                Text = $"Failed: {failed} ({failRate:0.0}%)",
                Location = new Point(250, 38),
                Size = new Size(220, 25),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(190, 55, 55)
            };

            Label lblTotal = new Label
            {
                Text = $"Total Students: {total}",
                Location = new Point(500, 38),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.Navy
            };

            Panel chartPanel = new Panel
            {
                Location = new Point(15, 67),
                Size = new Size(735, 65),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = new int[] { passed, failed }
            };

            chartPanel.Paint += CourseChart_Paint;

            DataGridView grid = CreateGradesGrid();

            grid.Location = new Point(15, 140);
            grid.Size = new Size(735, 125);
            grid.Anchor = AnchorStyles.Top |
                          AnchorStyles.Bottom |
                          AnchorStyles.Left |
                          AnchorStyles.Right;

            // Bind the table to the grid
            grid.DataSource = grades;

            page.Controls.Add(lblCourseName);
            page.Controls.Add(lblPassed);
            page.Controls.Add(lblFailed);
            page.Controls.Add(lblTotal);
            page.Controls.Add(chartPanel);
            page.Controls.Add(grid);
        }

        // Load Grades For One Course
        private DataTable LoadCourseGrades(int courseID)
        {
            using SqlConnection connection =
                DatabaseConnection.GetConnection();

            string query = @"
                SELECT
                    S.StudentID,
                    S.FullName AS StudentName,
                    G.Score,
                    G.LetterGrade,
                    G.Status
                FROM Grades G
                INNER JOIN Students S
                    ON G.StudentID = S.StudentID
                WHERE G.CourseID = @CourseID
                ORDER BY S.StudentID;";

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@CourseID",
                SqlDbType.Int).Value = courseID;

            using SqlDataAdapter adapter =
                new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // Create Grid With Explicit Columns
        private DataGridView CreateGradesGrid()
        {
            DataGridView grid = new DataGridView
            {
                AutoGenerateColumns = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                MultiSelect = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                Font = new Font("Segoe UI", 8.5F)
            };

            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Navy;

            grid.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            grid.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 8.5F, FontStyle.Bold);

            grid.DefaultCellStyle.ForeColor = Color.Navy;

            grid.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 230, 242);

            grid.DefaultCellStyle.SelectionForeColor =
                Color.Navy;

            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 247, 252);

            // Student ID
            AddGridColumn(
                grid,
                "StudentID",
                "StudentID",
                "Student ID");

            // Student Name
            AddGridColumn(
                grid,
                "StudentName",
                "StudentName",
                "Student Name");

            // Score
            DataGridViewTextBoxColumn scoreColumn =
                AddGridColumn(
                    grid,
                    "Score",
                    "Score",
                    "Score");

            scoreColumn.DefaultCellStyle.Format = "0.00";

            // Letter Grade
            AddGridColumn(
                grid,
                "LetterGrade",
                "LetterGrade",
                "Letter Grade");

            // Status
            AddGridColumn(
                grid,
                "Status",
                "Status",
                "Status");

            return grid;
        }

        // Add A Column And Connect It To A DataTable Field
        private DataGridViewTextBoxColumn AddGridColumn(
            DataGridView grid,
            string columnName,
            string dataPropertyName,
            string headerText)
        {
            DataGridViewTextBoxColumn column =
                new DataGridViewTextBoxColumn();

            column.Name = columnName;
            column.DataPropertyName = dataPropertyName;
            column.HeaderText = headerText;
            column.ReadOnly = true;
            column.SortMode =
                DataGridViewColumnSortMode.NotSortable;

            grid.Columns.Add(column);

            return column;
        }

        // Draw Passed And Failed Chart
        private void CourseChart_Paint(
            object sender,
            PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel == null || panel.Tag is not int[] values)
                return;

            int passed = values[0];
            int failed = values[1];
            int total = passed + failed;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int x = 15;
            int y = 16;
            int width = panel.ClientSize.Width - 30;
            int height = 24;

            if (total == 0)
            {
                g.DrawString(
                    "No grades available",
                    panel.Font,
                    Brushes.Gray,
                    x,
                    y);

                return;
            }

            int passedWidth =
                (int)(width * (passed / (double)total));

            int failedWidth = width - passedWidth;

            using SolidBrush passedBrush =
                new SolidBrush(Color.FromArgb(35, 155, 95));

            using SolidBrush failedBrush =
                new SolidBrush(Color.FromArgb(205, 75, 75));

            if (passedWidth > 0)
            {
                g.FillRectangle(
                    passedBrush,
                    x,
                    y,
                    passedWidth,
                    height);
            }

            if (failedWidth > 0)
            {
                g.FillRectangle(
                    failedBrush,
                    x + passedWidth,
                    y,
                    failedWidth,
                    height);
            }

            using Font labelFont =
                new Font("Segoe UI", 8F, FontStyle.Bold);

            if (passedWidth > 55)
            {
                g.DrawString(
                    $"Passed {passed}",
                    labelFont,
                    Brushes.White,
                    x + 5,
                    y + 4);
            }

            if (failedWidth > 55)
            {
                g.DrawString(
                    $"Failed {failed}",
                    labelFont,
                    Brushes.White,
                    x + passedWidth + 5,
                    y + 4);
            }
        }

        // Refresh Reports
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReportStatistics();
            LoadCourseReports();

            MessageBox.Show(
                "All course reports have been refreshed.",
                "Refresh",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Export All Course Reports To Excel
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (coursesTable == null || coursesTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "There are no courses to export.",
                        "Export Excel",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                using SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                    FileName = "Student_Grades_Report.xlsx",
                    Title = "Export Course Reports"
                };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                using XLWorkbook workbook = new XLWorkbook();

                HashSet<string> usedNames =
                    new HashSet<string>(
                        StringComparer.OrdinalIgnoreCase);

                foreach (DataRow course in coursesTable.Rows)
                {
                    int courseID =
                        Convert.ToInt32(course["CourseID"]);

                    string courseCode =
                        Convert.ToString(course["CourseCode"]) ?? "";

                    string courseName =
                        Convert.ToString(course["CourseName"]) ?? "";

                    string sheetName =
                        GetUniqueSheetName(courseCode, usedNames);

                    IXLWorksheet sheet =
                        workbook.Worksheets.Add(sheetName);

                    DataTable grades =
                        LoadCourseGrades(courseID);

                    sheet.Cell(1, 1).Value = courseName;

                    sheet.Cell(2, 1).Value = "Student ID";
                    sheet.Cell(2, 2).Value = "Student Name";
                    sheet.Cell(2, 3).Value = "Score";
                    sheet.Cell(2, 4).Value = "Letter Grade";
                    sheet.Cell(2, 5).Value = "Status";

                    for (int i = 0; i < grades.Rows.Count; i++)
                    {
                        DataRow row = grades.Rows[i];
                        int excelRow = i + 3;

                        sheet.Cell(excelRow, 1).Value =
                            Convert.ToInt32(row["StudentID"]);

                        sheet.Cell(excelRow, 2).Value =
                            Convert.ToString(row["StudentName"]) ?? "";

                        sheet.Cell(excelRow, 3).Value =
                            Convert.ToDouble(row["Score"]);

                        sheet.Cell(excelRow, 4).Value =
                            Convert.ToString(row["LetterGrade"]) ?? "";

                        sheet.Cell(excelRow, 5).Value =
                            Convert.ToString(row["Status"]) ?? "";
                    }

                    var titleRange = sheet.Range(1, 1, 1, 5);
                    titleRange.Merge();
                    titleRange.Style.Font.Bold = true;
                    titleRange.Style.Font.FontSize = 14;
                    titleRange.Style.Font.FontColor = XLColor.White;
                    titleRange.Style.Fill.BackgroundColor =
                        XLColor.FromArgb(31, 45, 75);

                    var headerRange = sheet.Range(2, 1, 2, 5);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Font.FontColor = XLColor.White;
                    headerRange.Style.Fill.BackgroundColor =
                        XLColor.FromArgb(55, 75, 130);

                    sheet.Columns().AdjustToContents();
                    sheet.SheetView.FreezeRows(2);
                }

                workbook.SaveAs(dialog.FileName);

                MessageBox.Show(
                    "Excel report exported successfully.",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Excel export failed:\n\n" + ex.Message,
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Generate A Valid Unique Excel Sheet Name
        private string GetUniqueSheetName(
            string originalName,
            HashSet<string> usedNames)
        {
            string name = string.IsNullOrWhiteSpace(originalName)
                ? "Course"
                : originalName;

            char[] invalidCharacters =
                { ':', '\\', '/', '?', '*', '[', ']' };

            foreach (char character in invalidCharacters)
            {
                name = name.Replace(character, '_');
            }

            name = name.Trim();

            if (name.Length > 31)
                name = name.Substring(0, 31);

            string baseName = name;
            int counter = 1;

            while (usedNames.Contains(name))
            {
                string suffix = "_" + counter++;

                int allowedLength = 31 - suffix.Length;

                name = baseName.Substring(
                    0,
                    Math.Min(baseName.Length, allowedLength))
                    + suffix;
            }

            usedNames.Add(name);

            return name;
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

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Hide();

            using (GradesForm form = new GradesForm())
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
