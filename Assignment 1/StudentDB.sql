-- Create the database 
USE "master";
DROP DATABASE IF EXISTS StudentDB;
CREATE DATABASE StudentDB;
GO

-- Use the database
USE StudentDB;
GO

-- Create the User table
CREATE TABLE [User] (
id INT PRIMARY KEY,
username VARCHAR(50) UNIQUE NOT NULL,
[password] VARCHAR(100) NOT NULL,
full_name NVARCHAR(250) NOT NULL,
avatar_url NVARCHAR(100) Null,
[role] VARCHAR(10) CHECK ([role] IN ('Admin', 'Manager')) DEFAULT 'Manager'
)

-- Create the Student table
CREATE TABLE ClassMember (
    member_id VARCHAR(10) PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    date_of_birth DATE,
	[role] VARCHAR(10) CHECK ([role] IN('Student', 'Teacher')) DEFAULT 'Student',
	gender VARCHAR(10) CHECK (gender IN('Male', 'Female')) DEFAULT 'Male'
);
GO

-- Create the Class table
CREATE TABLE Class (
    class_id INT PRIMARY KEY,
    class_name VARCHAR(50) NOT NULL,
);
GO

-- Create the join table for the many-to-many relationship
CREATE TABLE MemberClass (
    member_id VARCHAR(10),
    class_id INT,
    PRIMARY KEY (member_id, class_id),
    FOREIGN KEY (member_id) REFERENCES ClassMember (member_id),
    FOREIGN KEY (class_id) REFERENCES Class (class_id)
);
GO


