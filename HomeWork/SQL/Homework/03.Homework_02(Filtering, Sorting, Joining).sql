/*
Requirement 1/6 homework_02
Find all Students with FirstName = Antonio
Find all Students with DateOfBirth greater than ‘01.01.1999’
Find all Male students
Find all Students with LastName starting With ‘T’
Find all Students Enrolled in January/1998
Find all Students with LastName starting With ‘J’ enrolled in January/1998
*/
USE [SEDC_Homework]
GO

SELECT *
FROM dbo.Student AS s
WHERE s.FirstName = 'Antonio'
GO

SELECT *
FROM dbo.Student AS s
WHERE s.DateOfBirth > '01.01.1999'
GO

SELECT *
FROM dbo.Student AS s
WHERE s.Gender = 'M'
GO

SELECT *
FROM dbo.Student AS s
WHERE s.LastName like 'T%'
GO

SELECT *
FROM dbo.Student AS s
WHERE  MONTH(s.EnrolledDate) = 1 AND YEAR(s.EnrolledDate) = 1998
GO

SELECT *
FROM dbo.Student AS s
WHERE  MONTH(s.EnrolledDate) = 1 
AND YEAR(s.EnrolledDate) = 1998
AND s.LastName like 'J%'
GO

/*
Requirement 2/6 homework_02
Find all Students with FirstName = Antonio ordered by Last Name
List all Students ordered by FirstName
Find all Male students ordered by EnrolledDate, starting from the last enrolled
*/

SELECT *
FROM dbo.Student AS s
WHERE s.FirstName = 'ANTONIO'
ORDER BY s.LastName --DESC
GO

SELECT *
FROM dbo.Student AS s
ORDER BY s.FirstName
GO

SELECT *
FROM dbo.Student AS s
WHERE s.Gender = 'M'
ORDER BY s.EnrolledDate DESC
GO

/*
Requirement 3/6 homework_02
List all Teacher First Names and Student First Names in single result set with duplicates
List all Teacher Last Names and Student Last Names in single result set. Remove duplicates
List all common First Names for Teachers and Students
*/

SELECT t.FirstName
FROM dbo.Teacher AS t
UNION ALL
SELECT s.FirstName
FROM dbo.Student AS s
GO

SELECT t.LastName
FROM dbo.Teacher AS t
UNION 
SELECT s.LastName
FROM dbo.Student AS s
GO

SELECT t.FirstName
FROM dbo.Teacher AS t
INTERSECT
SELECT s.FirstName
FROM dbo.Student AS s
GO

/*
Requirement 4/6 homework_02
Change GradeDetails table always to insert value 100 in AchievementMaxPoints column if no value is provided on insert
Change GradeDetails table to prevent inserting AchievementPoints that will be more than AchievementMaxPoints (ALREADY DONE WHEN CREATING TABLES)
Change AchievementType table to guarantee unique names across the Achievement types
*/

ALTER TABLE dbo.GradeDetails
ADD CONSTRAINT DF_AchievementMaxPoints_GradeDetails
DEFAULT 100 FOR AchievementMaxPoints
GO

ALTER TABLE dbo.AchievementType WITH CHECK 
ADD CONSTRAINT UC_Name_AchievementType
UNIQUE ([Name])
GO


/*
Requirement 5/6 homework_02
Create Foreign key constraints from diagram or with script
*/
--ALREADY DONE WHEN CREATING TABLES 


/*
Requirement 6/6 homework_02
List all possible combinations of Courses names and AchievementType names that can be passed by student
List all Teachers that has any exam Grade
List all Teachers without exam Grade
List all Students without exam Grade (using Right Join)
*/

SELECT c.[Name] AS CourseName, a.Name AS AchievementTypeName
FROM dbo.Course as c
CROSS JOIN dbo.AchievementType as a
GO

SELECT DISTINCT t.FirstName, t.LastName
FROM dbo.Teacher as t
INNER JOIN dbo.Grade as g ON t.Id = g.TeacherID
GO

SELECT DISTINCT t.FirstName, t.LastName
FROM dbo.Teacher as t
LEFT JOIN dbo.Grade as g ON t.Id = g.TeacherID
WHERE g.id IS NULL
GO

SELECT s.FirstName, s.LastName
FROM dbo.Grade AS g 
RIGHT JOIN dbo.Student AS s ON s.Id = g.StudentID
WHERE g.id IS NULL
GO