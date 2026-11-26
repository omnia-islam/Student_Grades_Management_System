/*
Student Grades Management System
Portable SQL Server setup script
Database: StudentGradesDB

Run this script in SQL Server Management Studio.
It creates the database if needed, creates the tables, and inserts the sample data.

SAFETY: This script stops if any of the four project tables already exist.
It does not drop tables or delete existing records.
*/

USE master;
GO

IF DB_ID(N'StudentGradesDB') IS NULL
    CREATE DATABASE StudentGradesDB;
GO

USE StudentGradesDB;
GO

IF OBJECT_ID(N'dbo.Admins', N'U') IS NOT NULL
   OR OBJECT_ID(N'dbo.Students', N'U') IS NOT NULL
   OR OBJECT_ID(N'dbo.Courses', N'U') IS NOT NULL
   OR OBJECT_ID(N'dbo.Grades', N'U') IS NOT NULL
BEGIN
    THROW 50001, 'Setup stopped: one or more project tables already exist in StudentGradesDB. Use a fresh database or inspect it before proceeding.', 1;
END;
GO

CREATE TABLE dbo.Admins
(
    AdminID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Admins PRIMARY KEY,
    Username nvarchar(50) NOT NULL CONSTRAINT UQ_Admins_Username UNIQUE,
    PasswordHash nvarchar(255) NOT NULL,
    FullName nvarchar(100) NOT NULL
);
GO

CREATE TABLE dbo.Students
(
    StudentID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Students PRIMARY KEY,
    FullName nvarchar(100) NOT NULL,
    Email nvarchar(100) NULL,
    Phone nvarchar(20) NULL,
    Department nvarchar(100) NULL
);
GO

CREATE TABLE dbo.Courses
(
    CourseID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Courses PRIMARY KEY,
    CourseName nvarchar(100) NOT NULL,
    CourseCode nvarchar(20) NOT NULL CONSTRAINT UQ_Courses_CourseCode UNIQUE,
    CreditHours int NOT NULL,
    Instructor nvarchar(100) NULL
);
GO

CREATE TABLE dbo.Grades
(
    GradeID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Grades PRIMARY KEY,
    StudentID int NOT NULL,
    CourseID int NOT NULL,
    Score decimal(5,2) NOT NULL,
    LetterGrade nvarchar(2) NULL,
    Status nvarchar(10) NULL,
    CONSTRAINT UQ_Student_Course UNIQUE (StudentID, CourseID),
    CONSTRAINT CK_Grades_Score CHECK (Score >= 0 AND Score <= 100),
    CONSTRAINT FK_Grades_Students FOREIGN KEY (StudentID) REFERENCES dbo.Students(StudentID),
    CONSTRAINT FK_Grades_Courses FOREIGN KEY (CourseID) REFERENCES dbo.Courses(CourseID)
);
GO

SET IDENTITY_INSERT dbo.Admins ON;
INSERT dbo.Admins (AdminID, Username, PasswordHash, FullName)
VALUES (1, N'admin', N'E86F78A8A3CAF0B60D8E74E5942AA6D86DC150CD3C03338AEF25B7D2D7E3ACC7', N'System Administrator');
SET IDENTITY_INSERT dbo.Admins OFF;
GO

SET IDENTITY_INSERT dbo.Courses ON;
INSERT dbo.Courses (CourseID, CourseName, CourseCode, CreditHours, Instructor) VALUES
(1, N'Database Systems', N'CS301', 3, N'Dr. Ahmed'),
(2, N'Programming Fundamentals', N'CS101', 3, N'Dr. Sara'),
(3, N'Data Structures', N'CS201', 3, N'Dr. Mohamed'),
(4, N'Operating Systems', N'CS302', 3, N'Dr. Hany'),
(5, N'Software Engineering', N'CS401', 3, N'Dr. Mona'),
(6, N'Artificial Intelligence', N'CS501', 3, N'Dr. Yara'),
(7, N'Web Development', N'CS402', 3, N'Dr. Karim'),
(8, N'Computer Networks', N'CS303', 3, N'Dr. Amr');
SET IDENTITY_INSERT dbo.Courses OFF;
GO

SET IDENTITY_INSERT dbo.Students ON;
INSERT dbo.Students (StudentID, FullName, Email, Phone, Department) VALUES
(1, N'Ahmed Mohamed', N'ahmed@gmail.com', N'01011111111', N'Computer Science'),
(2, N'Sara Ali', N'sara@gmail.com', N'01022222222', N'Information Systems'),
(3, N'Mona Hassan', N'mona@gmail.com', N'01033333333', N'Computer Science'),
(4, N'Omar Khaled', N'omar@gmail.com', N'01044444444', N'Information Technology'),
(5, N'Nour Ahmed', N'nour@gmail.com', N'01055555555', N'Computer Science'),
(6, N'Youssef Adel', N'youssef@gmail.com', N'01066666666', N'Information Systems'),
(7, N'Farah Samir', N'farah@gmail.com', N'01077777777', N'Computer Science'),
(8, N'Malak Tarek', N'malak@gmail.com', N'01088888888', N'Information Technology'),
(10, N'Lina Mostafa', N'lina.mostafa@gmail.com', N'01099911111', N'Computer Science'),
(11, N'Karim Hassan', N'karim.hassan@gmail.com', N'01099922222', N'Information Systems'),
(12, N'Jana Ahmed', N'jana.ahmed@gmail.com', N'01099933333', N'Computer Science'),
(13, N'Adam Mahmoud', N'adam.mahmoud@gmail.com', N'01099944444', N'Information Technology'),
(14, N'Salma Tarek', N'salma.tarek@gmail.com', N'01099955555', N'Computer Science');
SET IDENTITY_INSERT dbo.Students OFF;
GO

SET IDENTITY_INSERT dbo.Grades ON;
INSERT dbo.Grades (GradeID, StudentID, CourseID, Score, LetterGrade, Status) VALUES
(1,1,1,95.00,N'A+',N'Passed'),
(2,2,1,92.00,N'A+',N'Passed'),
(3,5,1,98.00,N'A+',N'Passed'),
(4,1,2,88.00,N'A',N'Passed'),
(5,3,2,78.00,N'B',N'Passed'),
(6,6,2,73.00,N'B',N'Passed'),
(7,2,3,85.00,N'A',N'Passed'),
(8,4,3,65.00,N'C',N'Passed'),
(9,7,3,96.00,N'A+',N'Passed'),
(10,3,4,90.00,N'A+',N'Passed'),
(11,5,4,87.00,N'A',N'Passed'),
(12,7,4,89.00,N'A',N'Passed'),
(13,4,5,48.00,N'F',N'Failed'),
(14,6,5,82.00,N'B+',N'Passed'),
(15,8,5,76.00,N'B',N'Passed'),
(16,10,6,96.00,N'A+',N'Passed'),
(17,11,6,82.00,N'B+',N'Passed'),
(18,12,6,94.00,N'A',N'Passed'),
(19,13,6,68.00,N'C',N'Passed'),
(20,14,6,87.00,N'A',N'Passed'),
(21,10,7,91.00,N'A',N'Passed'),
(22,11,7,79.00,N'B',N'Passed'),
(23,12,7,97.00,N'A+',N'Passed'),
(24,13,7,74.00,N'C',N'Passed'),
(25,14,7,93.00,N'A',N'Passed'),
(26,10,8,88.00,N'A',N'Passed'),
(27,11,8,85.00,N'A',N'Passed'),
(28,12,8,90.00,N'A',N'Passed'),
(29,13,8,81.00,N'B+',N'Passed'),
(30,14,8,76.00,N'B',N'Passed'),
(31,10,1,89.00,N'A',N'Passed'),
(32,11,2,72.00,N'C',N'Passed'),
(33,12,3,98.00,N'A+',N'Passed'),
(34,13,4,55.00,N'D',N'Passed'),
(35,14,5,92.00,N'A',N'Passed'),
(36,3,1,53.00,N'D',N'Passed'),
(37,4,1,70.00,N'C',N'Passed'),
(38,6,1,48.00,N'F',N'Failed'),
(39,7,1,65.00,N'C',N'Passed'),
(40,8,1,82.00,N'B+',N'Passed'),
(41,11,1,77.00,N'B',N'Passed'),
(42,12,1,94.00,N'A',N'Passed'),
(43,13,1,55.00,N'D',N'Passed'),
(44,14,1,72.00,N'C',N'Passed'),
(45,2,2,49.00,N'F',N'Failed'),
(46,4,2,83.00,N'B+',N'Passed'),
(47,5,2,100.00,N'A+',N'Passed'),
(48,7,2,78.00,N'B',N'Passed'),
(49,8,2,95.00,N'A+',N'Passed'),
(50,10,2,73.00,N'C',N'Passed'),
(51,12,2,51.00,N'D',N'Passed'),
(52,13,2,68.00,N'C',N'Passed'),
(53,14,2,85.00,N'A',N'Passed'),
(54,1,3,45.00,N'F',N'Failed'),
(55,3,3,79.00,N'B',N'Passed'),
(56,5,3,57.00,N'D',N'Passed'),
(57,6,3,74.00,N'C',N'Passed'),
(58,8,3,52.00,N'D',N'Passed'),
(59,10,3,86.00,N'A',N'Passed'),
(60,11,3,47.00,N'F',N'Failed'),
(61,13,3,81.00,N'B+',N'Passed'),
(62,14,3,98.00,N'A+',N'Passed'),
(63,1,4,58.00,N'D',N'Passed'),
(64,2,4,75.00,N'B',N'Passed'),
(65,4,4,53.00,N'D',N'Passed'),
(66,6,4,87.00,N'A',N'Passed'),
(67,8,4,65.00,N'C',N'Passed'),
(68,10,4,99.00,N'A+',N'Passed'),
(69,11,4,60.00,N'D',N'Passed'),
(70,12,4,77.00,N'B',N'Passed'),
(71,14,4,55.00,N'D',N'Passed'),
(72,1,5,71.00,N'C',N'Passed'),
(73,2,5,88.00,N'A',N'Passed'),
(74,3,5,49.00,N'F',N'Failed'),
(75,5,5,83.00,N'B+',N'Passed'),
(76,7,5,61.00,N'D',N'Passed'),
(77,10,5,56.00,N'D',N'Passed'),
(78,11,5,73.00,N'C',N'Passed'),
(79,12,5,90.00,N'A',N'Passed'),
(80,13,5,51.00,N'D',N'Passed'),
(81,1,6,84.00,N'B+',N'Passed'),
(82,2,6,45.00,N'F',N'Failed'),
(83,3,6,62.00,N'D',N'Passed'),
(84,4,6,79.00,N'B',N'Passed'),
(85,5,6,96.00,N'A+',N'Passed'),
(86,6,6,57.00,N'D',N'Passed'),
(87,7,6,74.00,N'C',N'Passed'),
(88,8,6,91.00,N'A',N'Passed'),
(89,1,7,97.00,N'A+',N'Passed'),
(90,2,7,58.00,N'D',N'Passed'),
(91,3,7,75.00,N'B',N'Passed'),
(92,4,7,92.00,N'A',N'Passed'),
(93,5,7,53.00,N'D',N'Passed'),
(94,6,7,70.00,N'C',N'Passed'),
(95,7,7,87.00,N'A',N'Passed'),
(96,8,7,48.00,N'F',N'Failed'),
(97,1,8,54.00,N'D',N'Passed'),
(98,2,8,71.00,N'C',N'Passed'),
(99,3,8,88.00,N'A',N'Passed'),
(100,4,8,49.00,N'F',N'Failed'),
(101,5,8,66.00,N'C',N'Passed'),
(102,6,8,83.00,N'B+',N'Passed'),
(103,7,8,100.00,N'A+',N'Passed'),
(104,8,8,61.00,N'D',N'Passed');
SET IDENTITY_INSERT dbo.Grades OFF;
GO

SELECT N'Admins' AS TableName, COUNT(*) AS RecordCount FROM dbo.Admins
UNION ALL
SELECT N'Students', COUNT(*) FROM dbo.Students
UNION ALL
SELECT N'Courses', COUNT(*) FROM dbo.Courses
UNION ALL
SELECT N'Grades', COUNT(*) FROM dbo.Grades;
GO

PRINT N'StudentGradesDB setup completed.';
GO
