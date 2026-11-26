
namespace Student_Grades_Management_System
{
    partial class StudentsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            pnlMain = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            pnlStudentList = new Panel();
            dgvStudents = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            lblStudentsList = new Label();
            pnlStudentInfo = new Panel();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbDepartment = new ComboBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtStudentID = new TextBox();
            lblDepartment = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblStudentID = new Label();
            lblStudentInfo = new Label();
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
            pnlMain.SuspendLayout();
            pnlStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            pnlStudentInfo.SuspendLayout();
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
            pnlSidebar.TabIndex = 2;
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
            picStudents.BackColor = Color.FromArgb(128, 128, 255);
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
            btnStudents.BackColor = Color.FromArgb(128, 128, 255);
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
            pnlHeader.Size = new Size(870, 64);
            pnlHeader.TabIndex = 7;
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
            lbltitle.Size = new Size(271, 32);
            lbltitle.TabIndex = 7;
            lbltitle.Text = "Students Management";
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
            // pnlMain
            // 
            pnlMain.Controls.Add(txtSearch);
            pnlMain.Controls.Add(btnSearch);
            pnlMain.Controls.Add(pnlStudentList);
            pnlMain.Controls.Add(pnlStudentInfo);
            pnlMain.Location = new Point(222, 74);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(842, 579);
            pnlMain.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(369, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "   Search By Name or Student ID";
            txtSearch.Size = new Size(337, 34);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Navy;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(712, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlStudentList
            // 
            pnlStudentList.BackColor = Color.White;
            pnlStudentList.Controls.Add(dgvStudents);
            pnlStudentList.Controls.Add(lblStudentsList);
            pnlStudentList.Location = new Point(369, 55);
            pnlStudentList.Name = "pnlStudentList";
            pnlStudentList.Size = new Size(455, 510);
            pnlStudentList.TabIndex = 4;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { StudentID, FullNameColumn, Email, Phone, Department });
            dgvStudents.Location = new Point(22, 58);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(416, 432);
            dgvStudents.TabIndex = 1;
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "Student ID";
            StudentID.MinimumWidth = 8;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            FullNameColumn.DataPropertyName = "FullName";
            FullNameColumn.HeaderText = "Name";
            FullNameColumn.MinimumWidth = 8;
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Department
            // 
            Department.DataPropertyName = "Department";
            Department.HeaderText = "Department";
            Department.MinimumWidth = 8;
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // lblStudentsList
            // 
            lblStudentsList.AutoSize = true;
            lblStudentsList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsList.ForeColor = Color.Navy;
            lblStudentsList.Location = new Point(22, 10);
            lblStudentsList.Name = "lblStudentsList";
            lblStudentsList.Size = new Size(159, 32);
            lblStudentsList.TabIndex = 0;
            lblStudentsList.Text = "Students List";
            // 
            // pnlStudentInfo
            // 
            pnlStudentInfo.BackColor = Color.White;
            pnlStudentInfo.Controls.Add(btnDelete);
            pnlStudentInfo.Controls.Add(btnClear);
            pnlStudentInfo.Controls.Add(btnUpdate);
            pnlStudentInfo.Controls.Add(btnAdd);
            pnlStudentInfo.Controls.Add(cmbDepartment);
            pnlStudentInfo.Controls.Add(txtFullName);
            pnlStudentInfo.Controls.Add(txtEmail);
            pnlStudentInfo.Controls.Add(txtPhone);
            pnlStudentInfo.Controls.Add(txtStudentID);
            pnlStudentInfo.Controls.Add(lblDepartment);
            pnlStudentInfo.Controls.Add(lblPhone);
            pnlStudentInfo.Controls.Add(lblEmail);
            pnlStudentInfo.Controls.Add(lblFullName);
            pnlStudentInfo.Controls.Add(lblStudentID);
            pnlStudentInfo.Controls.Add(lblStudentInfo);
            pnlStudentInfo.Location = new Point(16, 12);
            pnlStudentInfo.Name = "pnlStudentInfo";
            pnlStudentInfo.Size = new Size(316, 553);
            pnlStudentInfo.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Navy;
            btnDelete.Location = new Point(159, 499);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(63, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Navy;
            btnClear.Location = new Point(228, 499);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.WhiteSmoke;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Navy;
            btnUpdate.Location = new Point(86, 499);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(63, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Navy;
            btnAdd.Location = new Point(17, 499);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(30, 419);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(242, 36);
            cmbDepartment.TabIndex = 11;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(34, 169);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(242, 34);
            txtFullName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 254);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 34);
            txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(33, 335);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(242, 34);
            txtPhone.TabIndex = 8;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(33, 101);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(242, 34);
            txtStudentID.TabIndex = 6;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.ForeColor = Color.Navy;
            lblDepartment.Location = new Point(30, 388);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(117, 28);
            lblDepartment.TabIndex = 5;
            lblDepartment.Text = "Department";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.Navy;
            lblPhone.Location = new Point(33, 304);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Navy;
            lblEmail.Location = new Point(34, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = Color.Navy;
            lblFullName.Location = new Point(30, 138);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 28);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.ForeColor = Color.Navy;
            lblStudentID.Location = new Point(34, 70);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(104, 28);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID";
            // 
            // lblStudentInfo
            // 
            lblStudentInfo.AutoSize = true;
            lblStudentInfo.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblStudentInfo.ForeColor = Color.Navy;
            lblStudentInfo.Location = new Point(20, 11);
            lblStudentInfo.Name = "lblStudentInfo";
            lblStudentInfo.Size = new Size(234, 31);
            lblStudentInfo.TabIndex = 0;
            lblStudentInfo.Text = "Student Information";
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 240);
            ClientSize = new Size(1076, 665);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students Management";
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
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlStudentList.ResumeLayout(false);
            pnlStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            pnlStudentInfo.ResumeLayout(false);
            pnlStudentInfo.PerformLayout();
            ResumeLayout(false);
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

        private Panel pnlMain;
        private Panel pnlStudentList;
        private Panel pnlStudentInfo;

        private Label lblStudentInfo;
        private Label lblDepartment;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblFullName;
        private Label lblStudentID;

        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtStudentID;

        private ComboBox cmbDepartment;

        private Button btnDelete;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;

        private Label lblStudentsList;
        private TextBox txtSearch;
        private Button btnSearch;

        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Department;
    }
}
