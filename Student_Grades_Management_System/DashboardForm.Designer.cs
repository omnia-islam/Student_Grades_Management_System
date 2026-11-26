namespace Student_Grades_Management_System
{
    partial class DashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblAppName = new Label();
            btnDashboard = new Button();
            btnStudents = new Button();
            btnCourses = new Button();
            btnGrades = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            picLogo = new PictureBox();
            pnlSidebar = new Panel();
            picLogout = new PictureBox();
            picReports = new PictureBox();
            picGrades = new PictureBox();
            picCourses = new PictureBox();
            picStudents = new PictureBox();
            picDashboard = new PictureBox();
            lblAdminName = new Label();
            pnlHeader = new Panel();
            picAdmin = new PictureBox();
            picMenu = new PictureBox();
            lbltitle = new Label();
            lblCoursesTitle = new Label();
            lblGradesCount = new Label();
            lblGradesTitle = new Label();
            lblGPATitle = new Label();
            lblCoursesCount = new Label();
            lblAverageGPA = new Label();
            pnlContent = new Panel();
            pnlGPACard = new Panel();
            picAverageGPA = new PictureBox();
            lblGPADescription = new Label();
            pnlCoursesCard = new Panel();
            picTotalCourses = new PictureBox();
            lblCoursesDescription = new Label();
            pnlGradesCard = new Panel();
            picTotalGrades = new PictureBox();
            lblGradesDescription = new Label();
            pnlStudentsCard = new Panel();
            picTotalStudents = new PictureBox();
            lblStudentsDescription = new Label();
            lblStudentsTitle = new Label();
            lblStudentsCount = new Label();
            pnlRecentGrades = new Panel();
            dgvRecentGrades = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            LetterGrade = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblRecentGrades = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            pnlContent.SuspendLayout();
            pnlGPACard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAverageGPA).BeginInit();
            pnlCoursesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalCourses).BeginInit();
            pnlGradesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalGrades).BeginInit();
            pnlStudentsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).BeginInit();
            pnlRecentGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentGrades).BeginInit();
            SuspendLayout();
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
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(128, 128, 255);
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
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(0, 270);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(202, 34);
            btnStudents.TabIndex = 2;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += button2_Click;
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
            // btnGrades
            // 
            btnGrades.FlatAppearance.BorderSize = 0;
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.ForeColor = Color.White;
            btnGrades.Location = new Point(3, 417);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(199, 32);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "Grades";
            btnGrades.UseVisualStyleBackColor = true;
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
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo__1_;
            picLogo.Location = new Point(43, 38);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(115, 68);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += pictureBox1_Click;
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
            pnlSidebar.TabIndex = 1;
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
            picLogout.Click += pictureBox2_Click;
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
            picReports.Click += pictureBox3_Click;
            // 
            // picGrades
            // 
            picGrades.Image = Properties.Resources.grades__1_;
            picGrades.Location = new Point(3, 417);
            picGrades.Name = "picGrades";
            picGrades.Size = new Size(30, 30);
            picGrades.TabIndex = 10;
            picGrades.TabStop = false;
            picGrades.Click += pictureBox4_Click;
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
            picCourses.Click += pictureBox5_Click;
            // 
            // picStudents
            // 
            picStudents.Image = Properties.Resources.students;
            picStudents.Location = new Point(3, 270);
            picStudents.Name = "picStudents";
            picStudents.Size = new Size(30, 30);
            picStudents.SizeMode = PictureBoxSizeMode.Zoom;
            picStudents.TabIndex = 12;
            picStudents.TabStop = false;
            // 
            // picDashboard
            // 
            picDashboard.BackColor = Color.FromArgb(128, 128, 255);
            picDashboard.Image = Properties.Resources.dashboard__1_;
            picDashboard.Location = new Point(3, 206);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(30, 30);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 7;
            picDashboard.TabStop = false;
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
            lblAdminName.Click += label2_Click;
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
            pnlHeader.Size = new Size(870, 64);
            pnlHeader.TabIndex = 6;
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
            lbltitle.Size = new Size(138, 32);
            lbltitle.TabIndex = 7;
            lbltitle.Text = "Dashboard";
            lbltitle.Click += label1_Click_1;
            // 
            // lblCoursesTitle
            // 
            lblCoursesTitle.AutoSize = true;
            lblCoursesTitle.Font = new Font("Segoe UI Semibold", 11F);
            lblCoursesTitle.ForeColor = Color.Navy;
            lblCoursesTitle.Location = new Point(257, 8);
            lblCoursesTitle.Name = "lblCoursesTitle";
            lblCoursesTitle.Size = new Size(145, 30);
            lblCoursesTitle.TabIndex = 10;
            lblCoursesTitle.Text = "Total Courses";
            lblCoursesTitle.Click += label2_Click_1;
            // 
            // lblGradesCount
            // 
            lblGradesCount.AutoSize = true;
            lblGradesCount.ForeColor = Color.Navy;
            lblGradesCount.Location = new Point(301, 64);
            lblGradesCount.Name = "lblGradesCount";
            lblGradesCount.Size = new Size(23, 28);
            lblGradesCount.TabIndex = 11;
            lblGradesCount.Text = "0";
            // 
            // lblGradesTitle
            // 
            lblGradesTitle.AutoSize = true;
            lblGradesTitle.Font = new Font("Segoe UI Semibold", 11F);
            lblGradesTitle.ForeColor = Color.Navy;
            lblGradesTitle.Location = new Point(231, 13);
            lblGradesTitle.Name = "lblGradesTitle";
            lblGradesTitle.Size = new Size(135, 30);
            lblGradesTitle.TabIndex = 14;
            lblGradesTitle.Text = "Total Grades";
            // 
            // lblGPATitle
            // 
            lblGPATitle.AutoSize = true;
            lblGPATitle.Font = new Font("Segoe UI Semibold", 11F);
            lblGPATitle.ForeColor = Color.Navy;
            lblGPATitle.Location = new Point(263, 15);
            lblGPATitle.Name = "lblGPATitle";
            lblGPATitle.Size = new Size(142, 30);
            lblGPATitle.TabIndex = 15;
            lblGPATitle.Text = "Average GPA";
            // 
            // lblCoursesCount
            // 
            lblCoursesCount.AutoSize = true;
            lblCoursesCount.ForeColor = Color.Navy;
            lblCoursesCount.Location = new Point(329, 57);
            lblCoursesCount.Name = "lblCoursesCount";
            lblCoursesCount.Size = new Size(23, 28);
            lblCoursesCount.TabIndex = 16;
            lblCoursesCount.Text = "0";
            // 
            // lblAverageGPA
            // 
            lblAverageGPA.AutoSize = true;
            lblAverageGPA.ForeColor = Color.Navy;
            lblAverageGPA.Location = new Point(329, 64);
            lblAverageGPA.Name = "lblAverageGPA";
            lblAverageGPA.Size = new Size(49, 28);
            lblAverageGPA.TabIndex = 18;
            lblAverageGPA.Text = "0.00";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.GhostWhite;
            pnlContent.Controls.Add(pnlGPACard);
            pnlContent.Controls.Add(pnlCoursesCard);
            pnlContent.Controls.Add(pnlGradesCard);
            pnlContent.Controls.Add(pnlStudentsCard);
            pnlContent.Location = new Point(207, 71);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(868, 343);
            pnlContent.TabIndex = 20;
            // 
            // pnlGPACard
            // 
            pnlGPACard.BackColor = Color.White;
            pnlGPACard.Controls.Add(picAverageGPA);
            pnlGPACard.Controls.Add(lblGPADescription);
            pnlGPACard.Controls.Add(lblGPATitle);
            pnlGPACard.Controls.Add(lblAverageGPA);
            pnlGPACard.Location = new Point(437, 189);
            pnlGPACard.Name = "pnlGPACard";
            pnlGPACard.Size = new Size(421, 150);
            pnlGPACard.TabIndex = 8;
            pnlGPACard.Paint += pnlGPACard_Paint;
            // 
            // picAverageGPA
            // 
            picAverageGPA.Image = Properties.Resources.Gemini_Generated_Image_wo54qywo54qywo54;
            picAverageGPA.Location = new Point(16, 26);
            picAverageGPA.Name = "picAverageGPA";
            picAverageGPA.Size = new Size(91, 84);
            picAverageGPA.SizeMode = PictureBoxSizeMode.Zoom;
            picAverageGPA.TabIndex = 21;
            picAverageGPA.TabStop = false;
            // 
            // lblGPADescription
            // 
            lblGPADescription.AutoSize = true;
            lblGPADescription.Font = new Font("Segoe UI", 7.5F);
            lblGPADescription.Location = new Point(292, 119);
            lblGPADescription.Name = "lblGPADescription";
            lblGPADescription.Size = new Size(113, 20);
            lblGPADescription.TabIndex = 21;
            lblGPADescription.Text = "Overall average";
            // 
            // pnlCoursesCard
            // 
            pnlCoursesCard.BackColor = Color.White;
            pnlCoursesCard.Controls.Add(picTotalCourses);
            pnlCoursesCard.Controls.Add(lblCoursesDescription);
            pnlCoursesCard.Controls.Add(lblCoursesTitle);
            pnlCoursesCard.Controls.Add(lblCoursesCount);
            pnlCoursesCard.Location = new Point(437, 4);
            pnlCoursesCard.Name = "pnlCoursesCard";
            pnlCoursesCard.Size = new Size(421, 150);
            pnlCoursesCard.TabIndex = 6;
            // 
            // picTotalCourses
            // 
            picTotalCourses.Image = Properties.Resources.total_grades;
            picTotalCourses.Location = new Point(16, 18);
            picTotalCourses.Name = "picTotalCourses";
            picTotalCourses.Size = new Size(91, 84);
            picTotalCourses.SizeMode = PictureBoxSizeMode.Zoom;
            picTotalCourses.TabIndex = 23;
            picTotalCourses.TabStop = false;
            // 
            // lblCoursesDescription
            // 
            lblCoursesDescription.AutoSize = true;
            lblCoursesDescription.Font = new Font("Segoe UI", 7.5F);
            lblCoursesDescription.Location = new Point(278, 120);
            lblCoursesDescription.Name = "lblCoursesDescription";
            lblCoursesDescription.Size = new Size(124, 20);
            lblCoursesDescription.TabIndex = 24;
            lblCoursesDescription.Text = "Available courses";
            // 
            // pnlGradesCard
            // 
            pnlGradesCard.BackColor = Color.White;
            pnlGradesCard.Controls.Add(picTotalGrades);
            pnlGradesCard.Controls.Add(lblGradesDescription);
            pnlGradesCard.Controls.Add(lblGradesTitle);
            pnlGradesCard.Controls.Add(lblGradesCount);
            pnlGradesCard.Location = new Point(10, 189);
            pnlGradesCard.Name = "pnlGradesCard";
            pnlGradesCard.Size = new Size(384, 150);
            pnlGradesCard.TabIndex = 7;
            // 
            // picTotalGrades
            // 
            picTotalGrades.Image = Properties.Resources.total_gradess;
            picTotalGrades.Location = new Point(18, 27);
            picTotalGrades.Name = "picTotalGrades";
            picTotalGrades.Size = new Size(91, 84);
            picTotalGrades.SizeMode = PictureBoxSizeMode.Zoom;
            picTotalGrades.TabIndex = 22;
            picTotalGrades.TabStop = false;
            // 
            // lblGradesDescription
            // 
            lblGradesDescription.AutoSize = true;
            lblGradesDescription.Font = new Font("Segoe UI", 7.5F);
            lblGradesDescription.Location = new Point(231, 119);
            lblGradesDescription.Name = "lblGradesDescription";
            lblGradesDescription.Size = new Size(122, 20);
            lblGradesDescription.TabIndex = 22;
            lblGradesDescription.Text = "Recorded grades";
            // 
            // pnlStudentsCard
            // 
            pnlStudentsCard.BackColor = Color.White;
            pnlStudentsCard.Controls.Add(picTotalStudents);
            pnlStudentsCard.Controls.Add(lblStudentsDescription);
            pnlStudentsCard.Controls.Add(lblStudentsTitle);
            pnlStudentsCard.Controls.Add(lblStudentsCount);
            pnlStudentsCard.Location = new Point(10, 4);
            pnlStudentsCard.Name = "pnlStudentsCard";
            pnlStudentsCard.Size = new Size(384, 150);
            pnlStudentsCard.TabIndex = 5;
            // 
            // picTotalStudents
            // 
            picTotalStudents.BackColor = Color.Transparent;
            picTotalStudents.Image = Properties.Resources.total_students;
            picTotalStudents.Location = new Point(18, 18);
            picTotalStudents.Name = "picTotalStudents";
            picTotalStudents.Size = new Size(91, 84);
            picTotalStudents.SizeMode = PictureBoxSizeMode.Zoom;
            picTotalStudents.TabIndex = 24;
            picTotalStudents.TabStop = false;
            // 
            // lblStudentsDescription
            // 
            lblStudentsDescription.AutoSize = true;
            lblStudentsDescription.Font = new Font("Segoe UI", 7.5F);
            lblStudentsDescription.ForeColor = Color.DimGray;
            lblStudentsDescription.Location = new Point(231, 120);
            lblStudentsDescription.Name = "lblStudentsDescription";
            lblStudentsDescription.Size = new Size(139, 20);
            lblStudentsDescription.TabIndex = 23;
            lblStudentsDescription.Text = "Registered students";
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.AutoSize = true;
            lblStudentsTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblStudentsTitle.ForeColor = Color.Navy;
            lblStudentsTitle.Location = new Point(212, 8);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(154, 30);
            lblStudentsTitle.TabIndex = 9;
            lblStudentsTitle.Text = "Total Students";
            lblStudentsTitle.Click += lblStudentsTitle_Click;
            // 
            // lblStudentsCount
            // 
            lblStudentsCount.AutoSize = true;
            lblStudentsCount.ForeColor = Color.Navy;
            lblStudentsCount.Location = new Point(301, 57);
            lblStudentsCount.Name = "lblStudentsCount";
            lblStudentsCount.Size = new Size(23, 28);
            lblStudentsCount.TabIndex = 12;
            lblStudentsCount.Text = "0";
            // 
            // pnlRecentGrades
            // 
            pnlRecentGrades.BackColor = Color.GhostWhite;
            pnlRecentGrades.Controls.Add(dgvRecentGrades);
            pnlRecentGrades.Controls.Add(lblRecentGrades);
            pnlRecentGrades.Location = new Point(207, 432);
            pnlRecentGrades.Name = "pnlRecentGrades";
            pnlRecentGrades.Size = new Size(868, 233);
            pnlRecentGrades.TabIndex = 21;
            // 
            // dgvRecentGrades
            // 
            dgvRecentGrades.AllowUserToAddRows = false;
            dgvRecentGrades.AllowUserToDeleteRows = false;
            dgvRecentGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentGrades.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 68, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentGrades.Columns.AddRange(new DataGridViewColumn[] { StudentName, CourseName, Score, LetterGrade, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 243, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = Color.GhostWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(52, 68, 92);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentGrades.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentGrades.Location = new Point(3, 56);
            dgvRecentGrades.MultiSelect = false;
            dgvRecentGrades.Name = "dgvRecentGrades";
            dgvRecentGrades.ReadOnly = true;
            dgvRecentGrades.RowHeadersVisible = false;
            dgvRecentGrades.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(246, 243, 240);
            dgvRecentGrades.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvRecentGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentGrades.Size = new Size(862, 170);
            dgvRecentGrades.TabIndex = 1;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 8;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course";
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
            // lblRecentGrades
            // 
            lblRecentGrades.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentGrades.ForeColor = Color.Navy;
            lblRecentGrades.Location = new Point(686, 13);
            lblRecentGrades.Name = "lblRecentGrades";
            lblRecentGrades.Size = new Size(172, 33);
            lblRecentGrades.TabIndex = 0;
            lblRecentGrades.Text = "Recent Grades";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1076, 665);
            Controls.Add(pnlRecentGrades);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tStudent Grades Management System";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            pnlContent.ResumeLayout(false);
            pnlGPACard.ResumeLayout(false);
            pnlGPACard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAverageGPA).EndInit();
            pnlCoursesCard.ResumeLayout(false);
            pnlCoursesCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalCourses).EndInit();
            pnlGradesCard.ResumeLayout(false);
            pnlGradesCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalGrades).EndInit();
            pnlStudentsCard.ResumeLayout(false);
            pnlStudentsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).EndInit();
            pnlRecentGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentGrades).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAppName;
        private Button btnDashboard;
        private Button btnStudents;
        private Button btnCourses;
        private Button btnGrades;
        private Button btnReports;
        private Button btnLogout;
        private PictureBox picLogo;
        private Panel pnlSidebar;
        private PictureBox picDashboard;
        private PictureBox picLogout;
        private PictureBox picReports;
        private PictureBox picGrades;
        private PictureBox picCourses;
        private PictureBox picStudents;
        private Label lblAdminName;
        private Panel pnlHeader;
        private Label lbltitle;
        private PictureBox picAdmin;
        private PictureBox picMenu;
        private Label lblCoursesTitle;
        private Label lblGradesCount;
        private Label lblGradesTitle;
        private Label lblGPATitle;
        private Label lblCoursesCount;
        private Label lblAverageGPA;
        private Panel pnlContent;
        private Panel pnlGPACard;
        private Panel pnlCoursesCard;
        private Panel pnlGradesCard;
        private Panel pnlStudentsCard;
        private Label lblStudentsTitle;
        private Label lblStudentsCount;
        private Label lblGPADescription;
        private Label lblCoursesDescription;
        private Label lblGradesDescription;
        private Label lblStudentsDescription;
        private PictureBox picAverageGPA;
        private PictureBox picTotalCourses;
        private PictureBox picTotalGrades;
        private PictureBox picTotalStudents;
        private Panel pnlRecentGrades;
        private Label lblRecentGrades;
        private DataGridView dgvRecentGrades;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn LetterGrade;
        private DataGridViewTextBoxColumn Status;
    }
}