USE StudentDB;
GO

-- Insert sample data into the User table

INSERT INTO [User] (id, username, [password], full_name, [role])
VALUES (1, 'admin', '123456', 'User Admin', 'Admin'),
		(2, 'manager', '123456', 'Manager', 'Manager')

-- Insert sample data into the Student table
INSERT INTO ClassMember (member_id, first_name, last_name, date_of_birth, gender)
VALUES
    ('SE160001', 'John', 'Doe', '2000-01-01', 'Male'),
    ('SE160002', 'Jane', 'Smith', '2001-02-03', 'Female'),
    ('SE160003', 'Michael', 'Johnson', '2000-05-10', 'Male'),
    ('SE160004', 'Emily', 'Brown', '2001-09-15', 'Female'),
    ('SE160005', 'David', 'Jones', '2000-03-20', 'Male'),
    ('SE160006', 'Sarah', 'Wilson', '2001-06-18', 'Female'),
    ('SE160007', 'Robert', 'Taylor', '2000-08-12', 'Male'),
    ('SE160008', 'Emma', 'Anderson', '2001-12-07', 'Female'),
    ('SE160009', 'Daniel', 'Clark', '2000-04-25', 'Male'),
    ('SE160010', 'Olivia', 'Martinez', '2001-07-30', 'Female'),
    ('SE160011', 'James', 'Harris', '2000-02-15', 'Male'),
    ('SE160012', 'Sophia', 'Lee', '2001-05-05', 'Female'),
    ('SE160013', 'Matthew', 'Walker', '2000-09-08', 'Male'),
    ('SE160014', 'Ava', 'Moore', '2001-11-22', 'Female'),
    ('SE160015', 'Ethan', 'Murphy', '2000-03-12', 'Male'),
    ('SE160016', 'Isabella', 'King', '2001-06-29', 'Female'),
    ('SE160017', 'Liam', 'Turner', '2000-10-02', 'Male'),
    ('SE160018', 'Mia', 'Scott', '2001-04-13', 'Female'),
    ('SE160019', 'Benjamin', 'Green', '2000-07-17', 'Male'),
    ('SE160020', 'Charlotte', 'Baker', '2001-09-24', 'Female'),
    ('SE160021', 'Lily', 'Adams', '2000-04-02', 'Female'),
    ('SE160022', 'Noah', 'Campbell', '2001-05-19', 'Male'),
    ('SE160023', 'Grace', 'Turner', '2000-09-25', 'Female'),
    ('SE160024', 'Logan', 'Carter', '2001-11-10', 'Male'),
    ('SE160025', 'Chloe', 'Parker', '2000-03-03', 'Female'),
    ('SE160026', 'Elijah', 'Harris', '2000-08-07', 'Male'),
    ('SE160027', 'Abigail', 'Bell', '2001-11-24', 'Female'),
    ('SE160028', 'Joshua', 'Turner', '2000-03-17', 'Male'),
	('SE160029', 'Ava', 'Watson', '2001-09-02', 'Female'),
	('SE160030', 'James', 'Foster', '2000-10-11', 'Male'),
    ('SE160031', 'Samantha', 'Murphy', '2001-02-26', 'Female'),
    ('SE160032', 'Carter', 'Parker', '2000-05-13', 'Male'),
    ('SE160033', 'Olivia', 'Scott', '2001-08-30', 'Female'),
    ('SE160034', 'Daniel', 'Reed', '2000-12-15', 'Male'),
    ('SE160035', 'Emily', 'Martinez', '2001-03-31', 'Female'),
    ('SE160036', 'Matthew', 'Anderson', '2000-07-18', 'Male'),
    ('SE160037', 'Harper', 'Johnson', '2001-09-03', 'Female'),
    ('SE160038', 'David', 'Baker', '2000-01-15', 'Male'),
    ('SE160039', 'Elizabeth', 'Wright', '2001-04-02', 'Female'),
    ('SE160040', 'Liam', 'Campbell', '2000-06-19', 'Male'),
    ('SE160041', 'Grace', 'Gonzalez', '2001-10-06', 'Female'),
    ('SE160042', 'Benjamin', 'Carter', '2000-02-20', 'Male'),
    ('SE160043', 'Chloe', 'Powell', '2001-05-07', 'Female'),
    ('SE160044', 'Lucas', 'Evans', '2000-08-24', 'Male'),
    ('SE160045', 'Sophia', 'Morris', '2001-12-10', 'Female'),
    ('SE160046', 'Jackson', 'Hughes', '2000-04-27', 'Male'),
    ('SE160047', 'Mia', 'Dixon', '2001-07-14', 'Female'),
    ('SE160048', 'Alexander', 'Simmons', '2000-09-30', 'Male'),
    ('SE160049', 'Charlotte', 'Reed', '2001-01-16', 'Female'),
    ('SE160050', 'Jacob', 'Harrison', '2000-05-02', 'Male'),
    ('SE160051', 'Scarlett', 'Stewart', '2001-08-19', 'Female'),
    ('SE160052', 'Henry', 'Watson', '2000-12-04', 'Male'),
    ('SE160053', 'Amelia', 'Harris', '2001-02-18', 'Female'),
    ('SE160054', 'Daniel', 'Butler', '2000-06-07', 'Male'),
    ('SE160055', 'Mila', 'Barnes', '2001-09-24', 'Female'),
    ('SE160056', 'Caleb', 'Ross', '2001-06-11', 'Male'),
    ('SE160057', 'Natalie', 'Wright', '2000-08-27', 'Female'),
	('SE160058', 'Ryan', 'Gonzalez', '2001-12-04', 'Male'),
    ('SE160059', 'Avery', 'Evans', '2000-04-21', 'Female'),
    ('SE160060', 'Victoria', 'Morris', '2001-07-28', 'Female'),
    ('SE160061', 'Dylan', 'Hughes', '2000-02-13', 'Male'),
    ('SE160062', 'Zoe', 'Powell', '2001-05-03', 'Female'),
    ('SE160063', 'Gabriel', 'Bennett', '2000-09-06', 'Male'),
    ('SE160064', 'Madison', 'Foster', '2001-11-20', 'Female'),
    ('SE160065', 'Jackson', 'Dixon', '2000-03-10', 'Male'),
    ('SE160066', 'Aubrey', 'Simmons', '2001-06-27', 'Female'),
    ('SE160067', 'Samuel', 'Reed', '2000-10-30', 'Male'),
    ('SE160068', 'Lillian', 'Harrison', '2001-04-07', 'Female'),
    ('SE160069', 'Henry', 'Stewart', '2000-07-13', 'Male'),
    ('SE160070', 'Addison', 'Watson', '2001-09-21', 'Female'),
    ('SE160071', 'Andrew', 'Harris', '2000-01-05', 'Male'),
    ('SE160072', 'Aria', 'Butler', '2001-02-17', 'Female'),
    ('SE160073', 'Wyatt', 'Barnes', '2000-05-07', 'Male'),
    ('SE160074', 'Sofia', 'Cook', '2001-08-23', 'Female'),
    ('SE160075', 'Elijah', 'Jenkins', '2000-12-29', 'Male'),
    ('SE160076', 'Brooklyn', 'Ward', '2001-03-13', 'Female'),
    ('SE160077', 'Luke', 'Sullivan', '2000-06-25', 'Male'),
    ('SE160078', 'Scarlett', 'Price', '2001-10-11', 'Female'),
    ('SE160079', 'Lucas', 'Anderson', '2000-02-28', 'Male'),
    ('SE160080', 'Emma', 'Harris', '2001-06-11', 'Female');


DECLARE @studentCounter INT = 81;

WHILE @studentCounter <= 99
BEGIN
    INSERT INTO ClassMember (member_id, first_name, last_name, date_of_birth, gender)
    VALUES
        ('SE1600' + CAST(@studentCounter AS VARCHAR(10)), 'Student' , '' + CAST(@studentCounter AS VARCHAR(10)), DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 364 ), '2002-01-01'), 'Female');

    SET @studentCounter += 1;
END;
GO


-- Insert 10 teachers into the ClassMember table
INSERT INTO ClassMember (member_id, first_name, last_name, date_of_birth, [role], gender)
VALUES
    ('ST000001', 'Adam', 'Smith', '1980-04-15', 'Teacher', 'Male'),
    ('ST000002', 'Emily', 'Johnson', '1985-09-22', 'Teacher', 'Female'),
    ('ST000003', 'Daniel', 'Williams', '1978-06-11', 'Teacher', 'Male'),
    ('ST000004', 'Sophia', 'Brown', '1983-02-28', 'Teacher', 'Female'),
    ('ST000005', 'Jacob', 'Miller', '1976-11-05', 'Teacher', 'Male'),
    ('ST000006', 'Ava', 'Davis', '1982-08-20', 'Teacher', 'Female'),
    ('ST000007', 'William', 'Taylor', '1979-03-10', 'Teacher', 'Male'),
    ('ST000008', 'Olivia', 'Anderson', '1984-12-17', 'Teacher', 'Female'),
    ('ST000009', 'Michael', 'Thomas', '1977-07-12', 'Teacher', 'Male'),
    ('ST000010', 'Emma', 'Wilson', '1981-10-29', 'Teacher', 'Female');
    
-- End of specific sample data rows for the ClassMember table

-- Insert sample data into the Class table
INSERT INTO Class (class_id, class_name)
VALUES
    (1, 'Mathematics'),
    (2, 'Science'),
    (3, 'English'),
    (4, 'History'),
    (5, 'Physics');
    -- Add more sample data for the Class table...

-- Insert sample data into the StudentClass table for the many-to-many relationship

DECLARE @studentCounter INT = 1;
WHILE @studentCounter <= 9
BEGIN
    INSERT INTO MemberClass (member_id, class_id)
    VALUES
        ('SE16000' + CAST(@studentCounter AS VARCHAR(10)), 1)
    SET @studentCounter += 1;
END;
GO

DECLARE @studentCounter INT = 10;
WHILE @studentCounter <= 20
BEGIN
    INSERT INTO MemberClass (member_id, class_id)
    VALUES
        ('SE1600' + CAST(@studentCounter AS VARCHAR(10)), 1)
    SET @studentCounter += 1;
END;
GO

DECLARE @studentCounter INT = 21;
WHILE @studentCounter <= 40
BEGIN
    INSERT INTO MemberClass (member_id, class_id)
    VALUES
        ('SE1600' + CAST(@studentCounter AS VARCHAR(10)), 2)
    SET @studentCounter += 1;
END;
GO

DECLARE @studentCounter INT = 41;
WHILE @studentCounter <= 60
BEGIN
    INSERT INTO MemberClass (member_id, class_id)
    VALUES
        ('SE1600' + CAST(@studentCounter AS VARCHAR(10)), 3)
    SET @studentCounter += 1;
END;
GO

DECLARE @studentCounter INT = 61;
WHILE @studentCounter <= 80
BEGIN
    INSERT INTO MemberClass (member_id, class_id)
    VALUES
        ('SE1600' + CAST(@studentCounter AS VARCHAR(10)), 4)
    SET @studentCounter += 1;
END;
GO

DECLARE @studentCounter INT = 81;
WHILE @studentCounter <= 99
BEGIN
    INSERT INTO MemberClass (member_id, class_id)
    VALUES
        ('SE1600' + CAST(@studentCounter AS VARCHAR(10)), 5)
    SET @studentCounter += 1;
END;
GO
    -- Add more sample data for the StudentClass table...

-- Add more sample data for the Student and Class tables...
