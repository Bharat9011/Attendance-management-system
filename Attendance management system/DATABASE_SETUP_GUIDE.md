# Database Setup Guide

## Overview
This document explains how to create the database for the Attendance Management System.

## Prerequisites
- SQL Server (Express or higher)
- SQL Server Management Studio (SSMS) or any SQL client
- The project source code

## Steps to Create the Database

### Step 1: Create the Database
1. Open SQL Server Management Studio
2. Connect to your SQL Server instance (e.g., `SHRIKHRISHNA\SQLEXPRESS`)
3. Right-click on "Databases" ? Select "New Database"
4. Name it `AMS` (as specified in Web.config)
5. Click OK

### Step 2: Execute the Schema Script
1. In SSMS, open a new query window
2. Select the `AMS` database from the dropdown
3. Open the file: `DatabaseSchema.sql`
4. Execute the script (F5 or Execute button)

### Step 3: Verify Tables Creation
Run this query to verify all tables were created:
```sql
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'AMS';
```

You should see the following tables:
- DepartmentDetail
- TeacherstaffDetail
- CourseDeatil
- SubjectTable
- StudentDetails
- AttendanceRecord
- Notification
- NotificationRecipient

### Step 4: Create Initial Admin User (Optional)
To log in to the application, you need at least one Principal user:

```sql
INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Computer Science');

INSERT INTO TeacherstaffDetail (name, email, password, role1, DepatmentName, permission) 
VALUES ('Admin', 'admin@school.com', 'admin123', 'Principal', 'Computer Science', 'YES');
```

You can then login with:
- Email: `admin@school.com`
- Password: `admin123`

### Step 5: Configure Connection String
The Web.config file already contains the connection string:
```xml
<add name="AMSConnectionString" 
     connectionString="Data Source=SHRIKHRISHNA\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True;" 
     providerName="System.Data.SqlClient" />
```

If your SQL Server instance name is different, update the connection string accordingly.

## Database Structure

### Tables Description

**DepartmentDetail**
- Stores department information

**TeacherstaffDetail**
- Stores information about all staff (Principal, HOD, Co-ordinator, Teacher)
- Columns: id, name, email, password, role1, DepatmentName, permission

**CourseDeatil**
- Stores course information associated with departments

**SubjectTable**
- Stores subject information created by coordinators
- Linked to courses and departments

**StudentDetails**
- Stores student profile information
- Includes email, contact, department, course, and session year

**AttendanceRecord**
- Stores attendance records for each student
- Records attendance status (Present, Absent, Leave)

**Notification**
- Stores notifications created by staff
- Can be targeted to specific roles

**NotificationRecipient**
- Tracks which staff members have received/read notifications

## Troubleshooting

### Connection Error
If you get a connection error:
1. Verify SQL Server is running
2. Check the server name is correct
3. Ensure Integrated Security is enabled or provide appropriate credentials
4. Verify the database `AMS` exists

### Script Execution Error
If the schema script fails:
1. Check that the `AMS` database is selected
2. Ensure you have admin privileges
3. Review the error message for specific table/constraint issues

## Adding Sample Data

After creating the basic tables, you can add sample departments and users:

```sql
-- Add Departments
INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Computer Science');
INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Electronics');
INSERT INTO DepartmentDetail (DepartmentName) VALUES ('Mechanical');

-- Add Principal
INSERT INTO TeacherstaffDetail (name, email, password, role1, DepatmentName, permission) 
VALUES ('Dr. Sharma', 'principal@school.com', 'principal@123', 'Principal', 'Computer Science', 'YES');

-- Add HOD
INSERT INTO TeacherstaffDetail (name, email, password, role1, DepatmentName, permission) 
VALUES ('Prof. Patel', 'hod@school.com', 'hod@123', 'HOD', 'Computer Science', 'YES');
```

## Next Steps
1. Build and run the project
2. Navigate to the application
3. Use the credentials you created to log in
4. Start creating departments, courses, and users through the application UI
