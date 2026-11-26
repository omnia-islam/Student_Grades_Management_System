namespace Student_Grades_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLoginCard = new Panel();
            chkShowPassword = new CheckBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblLogo = new Label();
            lblUsername = new Label();
            lblWelcome = new Label();
            label1 = new Label();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.GhostWhite;
            pnlLoginCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginCard.Controls.Add(chkShowPassword);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(lblLogo);
            pnlLoginCard.Controls.Add(lblUsername);
            pnlLoginCard.Controls.Add(lblWelcome);
            pnlLoginCard.Font = new Font("Segoe UI", 24F);
            pnlLoginCard.Location = new Point(153, 41);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(705, 524);
            pnlLoginCard.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10F);
            chkShowPassword.ForeColor = Color.Navy;
            chkShowPassword.Location = new Point(32, 354);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(172, 32);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(24, 194);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(655, 42);
            txtUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Navy;
            btnLogin.Location = new Point(253, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(201, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.Navy;
            lblPassword.Location = new Point(24, 255);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(157, 32);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(24, 290);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(655, 42);
            txtPassword.TabIndex = 4;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.FromArgb(64, 64, 64);
            lblLogo.Location = new Point(224, 90);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 22);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "Student Grades Management System";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.Navy;
            lblUsername.Location = new Point(24, 159);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(157, 32);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Navy;
            lblWelcome.Location = new Point(157, 31);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(380, 59);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(978, 594);
            Controls.Add(label1);
            Controls.Add(pnlLoginCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            Load += LoginForm_Load;
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLoginCard;
        private Label lblWelcome;
        private Label lblUsername;
        private Label lblLogo;
        private Label label1;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtUsername;
        private CheckBox chkShowPassword;
    }
}
