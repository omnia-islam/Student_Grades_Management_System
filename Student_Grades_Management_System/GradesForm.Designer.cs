namespace Student_Grades_Management_System
{
    partial class GradesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            picLogout = new PictureBox();
            picReports = new PictureBox();
            btnLogout = new Button();
            picGrades = new PictureBox();
            picCourses = new PictureBox();
            btnReports = new Button();
            picStudents = new PictureBox();
            picLogo = new PictureBox();
            btnGrades = new Button();
            lblAppName = new Label();
            picDashboard = new PictureBox();
            btnDashboard = new Button();
            btnStudents = new Button();
            btnCourses = new Button();
            pnlHeader = new Panel();
            picAdmin = new PictureBox();
            picMenu = new PictureBox();
            lbltitle = new Label();
            lblAdminName = new Label();
            txtSearchBar = new TextBox();
            btnSearch = new Button();
            dgvGrades = new DataGridView();
            GradeID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            LetterGrade = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Navy;
            pnlSidebar.Controls.Add(picLogout);
            pnlSidebar.Controls.Add(picReports);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(picGrades);
            pnlSidebar.Controls.Add(picCourses);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(picStudents);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Controls.Add(btnGrades);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Controls.Add(picDashboard);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnStudents);
            pnlSidebar.Controls.Add(btnCourses);
            pnlSidebar.Location = new Point(-1, 1);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(202, 664);
            pnlSidebar.TabIndex = 3;
            // 
            // picLogout
            // 
            picLogout.Image = Properties.Resources.logout;
            picLogout.Location = new Point(3, 561);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(30, 30);
            picLogout.SizeMode = PictureBoxSizeMode.Zoom;
            picLogout.TabIndex = 8;
            picLogout.TabStop = false;
            // 
            // picReports
            // 
            picReports.Image = Properties.Resources.reports;
            picReports.Location = new Point(3, 491);
            picReports.Name = "picReports";
            picReports.Size = new Size(30, 30);
            picReports.SizeMode = PictureBoxSizeMode.Zoom;
            picReports.TabIndex = 9;
            picReports.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(3, 554);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(199, 37);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // picGrades
            // 
            picGrades.BackColor = Color.FromArgb(128, 128, 255);
            picGrades.Image = Properties.Resources.grades__1_;
            picGrades.Location = new Point(3, 417);
            picGrades.Name = "picGrades";
            picGrades.Size = new Size(30, 30);
            picGrades.TabIndex = 10;
            picGrades.TabStop = false;
            // 
            // picCourses
            // 
            picCourses.Image = Properties.Resources.courses;
            picCourses.Location = new Point(3, 339);
            picCourses.Name = "picCourses";
            picCourses.Size = new Size(30, 30);
            picCourses.SizeMode = PictureBoxSizeMode.Zoom;
            picCourses.TabIndex = 11;
            picCourses.TabStop = false;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(3, 487);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(199, 34);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // picStudents
            // 
            picStudents.BackColor = Color.Navy;
            picStudents.Image = Properties.Resources.students;
            picStudents.Location = new Point(3, 270);
            picStudents.Name = "picStudents";
            picStudents.Size = new Size(30, 30);
            picStudents.SizeMode = PictureBoxSizeMode.Zoom;
            picStudents.TabIndex = 12;
            picStudents.TabStop = false;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo__1_;
            picLogo.Location = new Point(43, 38);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(115, 68);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnGrades
            // 
            btnGrades.BackColor = Color.FromArgb(128, 128, 255);
            btnGrades.FlatAppearance.BorderSize = 0;
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.ForeColor = Color.White;
            btnGrades.Location = new Point(3, 417);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(199, 32);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "Grades";
            btnGrades.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(3, 131);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(196, 38);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Student Grades";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picDashboard
            // 
            picDashboard.BackColor = Color.Navy;
            picDashboard.Image = Properties.Resources.dashboard__1_;
            picDashboard.Location = new Point(3, 206);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(30, 30);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 7;
            picDashboard.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Navy;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 206);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(202, 34);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.Navy;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(0, 270);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(202, 34);
            btnStudents.TabIndex = 2;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.ForeColor = Color.White;
            btnCourses.Location = new Point(0, 335);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(202, 34);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(picAdmin);
            pnlHeader.Controls.Add(picMenu);
            pnlHeader.Controls.Add(lbltitle);
            pnlHeader.Controls.Add(lblAdminName);
            pnlHeader.Location = new Point(205, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(876, 58);
            pnlHeader.TabIndex = 8;
            // 
            // picAdmin
            // 
            picAdmin.Image = Properties.Resources.Gemini_Generated_Image_ysh2i4ysh2i4ysh2;
            picAdmin.Location = new Point(814, 17);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(30, 30);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 9;
            picAdmin.TabStop = false;
            // 
            // picMenu
            // 
            picMenu.Image = Properties.Resources.Gemini_Generated_Image_dy3mpfdy3mpfdy3m;
            picMenu.Location = new Point(20, 15);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(30, 30);
            picMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picMenu.TabIndex = 10;
            picMenu.TabStop = false;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.Navy;
            lbltitle.Location = new Point(56, 15);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(251, 32);
            lbltitle.TabIndex = 7;
            lbltitle.Text = "Grades Management";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminName.ForeColor = Color.Navy;
            lblAdminName.Location = new Point(613, 15);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(195, 32);
            lblAdminName.TabIndex = 5;
            lblAdminName.Text = "Welcome, Admin";
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(739, 89);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.PlaceholderText = "Search Grades...";
            txtSearchBar.Size = new Size(209, 31);
            txtSearchBar.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Navy;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(966, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 34);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.BackgroundColor = Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Columns.AddRange(new DataGridViewColumn[] { GradeID, StudentID, CourseName, Score, LetterGrade, Status });
            dgvGrades.Location = new Point(225, 152);
            dgvGrades.MultiSelect = false;
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.RowHeadersVisible = false;
            dgvGrades.RowHeadersWidth = 62;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(817, 370);
            dgvGrades.TabIndex = 11;
            // 
            // GradeID
            // 
            GradeID.HeaderText = "Grade ID";
            GradeID.MinimumWidth = 8;
            GradeID.Name = "GradeID";
            GradeID.ReadOnly = true;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "Student ID";
            StudentID.MinimumWidth = 8;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 8;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.MinimumWidth = 8;
            Score.Name = "Score";
            Score.ReadOnly = true;
            // 
            // LetterGrade
            // 
            LetterGrade.HeaderText = "Letter Grade";
            LetterGrade.MinimumWidth = 8;
            LetterGrade.Name = "LetterGrade";
            LetterGrade.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // GradesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 665);
            Controls.Add(dgvGrades);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "GradesForm";
            Text = "GradesForm";
            Load += GradesForm_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private PictureBox picLogout;
        private PictureBox picReports;
        private Button btnLogout;
        private PictureBox picGrades;
        private PictureBox picCourses;
        private Button btnReports;
        private PictureBox picStudents;
        private PictureBox picLogo;
        private Button btnGrades;
        private Label lblAppName;
        private PictureBox picDashboard;
        private Button btnDashboard;
        private Button btnStudents;
        private Button btnCourses;
        private Panel pnlHeader;
        private PictureBox picAdmin;
        private PictureBox picMenu;
        private Label lbltitle;
        private Label lblAdminName;
        private TextBox txtSearchBar;
        private Button btnSearch;
        private DataGridView dgvGrades;
        private DataGridViewTextBoxColumn GradeID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn LetterGrade;
        private DataGridViewTextBoxColumn Status;
    }
}