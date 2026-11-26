
using System;
using System.Windows.Forms;

namespace Student_Grades_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += btnLogin_Click;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            txtUsername.UseSystemPasswordChar = false;

            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Allow any non-empty username and password
            this.Hide();

            DashboardForm dashboard = new DashboardForm();

            dashboard.FormClosed += (s, args) =>
            {
                this.Close();
            };

            dashboard.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
        }
    }
}
