
using Microsoft.Data.SqlClient;

namespace Student_Grades_Management_System.Data
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            @"Server=DESKTOP-86VJV2K\SQLEXPRESS01;Database=StudentGradesDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
