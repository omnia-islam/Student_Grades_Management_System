
# Student Grades Management System

A desktop application built using C# Windows Forms and SQL Server to manage students, courses, and grades.

## Technologies Used
- C#
- .NET 9
- Windows Forms
- SQL Server
- Microsoft.Data.SqlClient
- ClosedXML

## Features
- Admin Login
- Student Management
- Course Management
- Grades Management
- Reports

## Requirements
- Windows
- Visual Studio 2022 or later with the .NET desktop development workload
- .NET 9 SDK
- SQL Server
- SQL Server Management Studio (SSMS)

## Database Setup
1. Open SQL Server Management Studio.
2. Open `Student_Grades_Management_System/Database/StudentGradesDB_Setup.sql`.
3. Execute the script to create the database and insert sample data.
4. Make sure the database is named `StudentGradesDB`.

## Configure Database Connection
1. Open `Student_Grades_Management_System/Data/DatabaseConnection.cs`.
2. Update the `Server` value in the connection string to match your SQL Server instance.
3. Keep the database name as `StudentGradesDB`.

## How to Run
1. Download or clone this repository.
2. If Windows blocks the downloaded ZIP, open its Properties and select **Unblock** (if available) before extracting it.
3. Extract the project files.
4. Open `Student_Grades_Management_System.slnx` in Visual Studio.
5. Allow NuGet packages to restore.
6. Build and run the solution.

## Project Structure
- `Student_Grades_Management_System/` - Main application project.
- `Student_Grades_Management_System/Data/` - Database connection and test files.
- `Student_Grades_Management_System/Database/` - Database setup script.
- `Student_Grades_Management_System/Properties/` - Application properties and resources.
- `Student_Grades_Management_System/Resources/` - Images and icons.

## Note
The SQL Server instance name may differ between computers. Update the connection string before running the application.
