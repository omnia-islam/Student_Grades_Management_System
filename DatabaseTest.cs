
using System;
using System.Windows.Forms;

namespace Student_Grades_Management_System.Data
{
    public static class DatabaseTest
    {
        public static void TestConnection()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Database connected successfully!",
                        "Connection Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
