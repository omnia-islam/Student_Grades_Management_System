
# Student Grades Management System

A desktop application developed using C# Windows Forms and SQL Server to manage students, courses, and grades.

## Technologies Used
- C#
- .NET 9
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient

## Features
- Admin Login
- Student Management
- Course Management
- Grades Management
- Reports

## Database Setup
1. Open SQL Server Management Studio (SSMS).
2. Open the script located at `Database/StudentGradesDB_Setup.sql`.
3. Execute the script to create the database and insert the sample data.
4. Open `Data/DatabaseConnection.cs`.
5. Update the SQL Server instance name in the connection string to match your local SQL Server instance.

## How to Run
1. Install Visual Studio with the .NET desktop development workload.
2. Install SQL Server.
3. Set up the database using the SQL script.
4. Open `Student_Grades_Management_System.slnx`.
5. Build and run the project.

## Project Structure
- `Data/` - Database connection and related files.
- `Database/` - Database setup script.
- `Properties/` - Project properties.
- `Resources/` - Application images and resources.

## Note
The SQL Server instance name may differ between computers. Update the connection string before running the application.
