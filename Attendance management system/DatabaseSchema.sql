-- Attendance Management System Database Schema
-- This script creates all tables needed for the application

-- Create DepartmentDetail Table
CREATE TABLE [dbo].[DepartmentDetail]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [DepartmentName] NVARCHAR(100) NOT NULL UNIQUE
);

-- Create TeacherstaffDetail Table
CREATE TABLE [dbo].[TeacherstaffDetail]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [name] NVARCHAR(100) NOT NULL,
    [email] NVARCHAR(100) NOT NULL UNIQUE,
    [password] NVARCHAR(100) NOT NULL,
    [role1] NVARCHAR(50) NOT NULL, -- Values: 'Principal', 'HOD', 'co-ordinator', 'teacher'
    [DepatmentName] NVARCHAR(100) NOT NULL,
    [permission] NVARCHAR(10) DEFAULT 'NO', -- Values: 'YES', 'NO', 'NOT'
    FOREIGN KEY ([DepatmentName]) REFERENCES [dbo].[DepartmentDetail]([DepartmentName])
);

-- Create CourseDeatil Table
CREATE TABLE [dbo].[CourseDeatil]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [CourseName] NVARCHAR(100) NOT NULL,
    [DepartmentName] NVARCHAR(100) NOT NULL,
    [Co_ordinator] NVARCHAR(100) NOT NULL,
    [CourseCode] NVARCHAR(50),
    FOREIGN KEY ([DepartmentName]) REFERENCES [dbo].[DepartmentDetail]([DepartmentName]),
    FOREIGN KEY ([Co_ordinator]) REFERENCES [dbo].[TeacherstaffDetail]([name])
);

-- Create SubjectTable
CREATE TABLE [dbo].[SubjectTable]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [SubjectName] NVARCHAR(100) NOT NULL,
    [SubjectTeacher] NVARCHAR(100) NOT NULL,
    [Year] NVARCHAR(10),
    [Semister] NVARCHAR(10),
    [SubjectCreateBy] INT,
    [SubjectDepartmentID] INT,
    [SubjctCourseID] INT,
    FOREIGN KEY ([SubjectCreateBy]) REFERENCES [dbo].[TeacherstaffDetail]([id]),
    FOREIGN KEY ([SubjectDepartmentID]) REFERENCES [dbo].[DepartmentDetail]([id]),
    FOREIGN KEY ([SubjctCourseID]) REFERENCES [dbo].[CourseDeatil]([id])
);

-- Create StudentDetails Table
CREATE TABLE [dbo].[StudentDetails]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [StudentName] NVARCHAR(100) NOT NULL,
    [StudentEmail] NVARCHAR(100) NOT NULL UNIQUE,
    [StudentContactNumber] NVARCHAR(15),
    [StudentDepartment] INT,
    [StudentCourse] INT,
    [StudentClass] NVARCHAR(50),
    [StudentSeesionYear] NVARCHAR(10),
    [StudentPassword] NVARCHAR(100),
    [CreateBy] INT,
    [Semister] NVARCHAR(10),
    FOREIGN KEY ([StudentDepartment]) REFERENCES [dbo].[DepartmentDetail]([id]),
    FOREIGN KEY ([StudentCourse]) REFERENCES [dbo].[CourseDeatil]([id]),
    FOREIGN KEY ([CreateBy]) REFERENCES [dbo].[TeacherstaffDetail]([id])
);

-- Create AttendanceRecord Table
CREATE TABLE [dbo].[AttendanceRecord]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [StudentID] INT NOT NULL,
    [SubjectID] INT,
    [AttendanceDate] DATE,
    [Status] NVARCHAR(10), -- Values: 'Present', 'Absent', 'Leave'
    [RecordedBy] INT,
    FOREIGN KEY ([StudentID]) REFERENCES [dbo].[StudentDetails]([id]),
    FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[SubjectTable]([id]),
    FOREIGN KEY ([RecordedBy]) REFERENCES [dbo].[TeacherstaffDetail]([id])
);

-- Create Notification Table
CREATE TABLE [dbo].[Notification]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [Title] NVARCHAR(200),
    [Description] NVARCHAR(MAX),
    [CreatedBy] INT,
    [CreatedDate] DATETIME DEFAULT GETDATE(),
    [TargetRole] NVARCHAR(50), -- Values: 'Principal', 'HOD', 'co-ordinator', 'teacher', 'student'
    [Status] NVARCHAR(20) DEFAULT 'Sent', -- Values: 'Draft', 'Sent', 'Read'
    FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[TeacherstaffDetail]([id])
);

-- Create NotificationRecipient Table
CREATE TABLE [dbo].[NotificationRecipient]
(
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [NotificationID] INT,
    [RecipientID] INT,
    [ReadStatus] BIT DEFAULT 0,
    [ReadDate] DATETIME,
    FOREIGN KEY ([NotificationID]) REFERENCES [dbo].[Notification]([id]),
    FOREIGN KEY ([RecipientID]) REFERENCES [dbo].[TeacherstaffDetail]([id])
);

-- Insert Sample Data (Optional)
-- You can uncomment and customize the following sample data:

-- INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Computer Science');
-- INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Electronics');
-- INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Mechanical');

-- INSERT INTO TeacherstaffDetail (name, email, password, role1, DepatmentName, permission) 
-- VALUES ('Admin Principal', 'principal@school.com', 'password123', 'Principal', 'Computer Science', 'YES');

-- INSERT INTO TeacherstaffDetail (name, email, password, role1, DepatmentName, permission) 
-- VALUES ('HOD CS', 'hod@school.com', 'password123', 'HOD', 'Computer Science', 'YES');

-- Create Indexes for better performance
CREATE INDEX IDX_TeacherstaffDetail_Email ON [dbo].[TeacherstaffDetail]([email]);
CREATE INDEX IDX_TeacherstaffDetail_DepatmentName ON [dbo].[TeacherstaffDetail]([DepatmentName]);
CREATE INDEX IDX_StudentDetails_Email ON [dbo].[StudentDetails]([StudentEmail]);
CREATE INDEX IDX_AttendanceRecord_StudentID ON [dbo].[AttendanceRecord]([StudentID]);
CREATE INDEX IDX_AttendanceRecord_Date ON [dbo].[AttendanceRecord]([AttendanceDate]);
