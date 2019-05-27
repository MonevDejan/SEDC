/*
Requirement 1/3 homework_03
Calculate the count of all grades in the system
Calculate the count of all grades per Teacher in the system
Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100)
Find the Maximal Grade, and the Average Grade per Student on all grades in the system
*/
USE [SEDC_Homework]

SELECT COUNT(g.Grade) AS TotalGradesNumber
FROM dbo.Grade AS g
GO

SELECT  t.id, t.FirstName, t.LastName, COUNT(g.Grade) AS GradePerTeacher
FROM dbo.Grade AS g
INNER JOIN dbo.Teacher AS t ON g.TeacherID = t.Id
GROUP BY t.FirstName, t.LastName, t.Id
ORDER BY t.id
GO


SELECT  t.id, t.FirstName, t.LastName, COUNT(g.Grade) AS GradePerTeacher
FROM dbo.Grade AS g
INNER JOIN dbo.Teacher AS t ON g.TeacherID = t.Id
INNER JOIN dbo.Student AS s ON s.Id = g.StudentID
WHERE s.Id < 100
GROUP BY t.FirstName, t.LastName, t.Id
ORDER BY t.id
GO

SELECT s.id, s.FirstName, s.LastName,  MAX(g.Grade) AS MaxGrade, AVG(Cast(g.Grade AS decimal(5,2))) AS AvgGrade
FROM dbo.Grade AS g
INNER JOIN dbo.Student AS s ON s.Id = g.StudentID
GROUP BY s.FirstName, s.LastName, s.id
ORDER BY s.Id
GO

/*
Requirement 2/3 homework_03
Calculate the count of all grades per Teacher in the system and filter only grade count greater then 200
Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100) and filter teachers with more than 50 Grade count
Find the Grade Count, Maximal Grade, and the Average Grade per Student on all grades in the system. 
Filter only records where Maximal Grade is equal to Average Grade
List Student First Name and Last Name next to the other details from previous query
*/

SELECT t.id, t.FirstName, t.LastName, COUNT(g.Grade) AS GradePerTeacher 
FROM dbo.Grade AS g
INNER JOIN dbo.Teacher AS t ON g.TeacherID = t.Id
GROUP BY t.FirstName, t.LastName, t.Id
HAVING COUNT(g.Grade) > 200
ORDER BY t.id
GO

SELECT t.id, t.FirstName, t.LastName, COUNT(g.Grade) AS GradePerTeacher
FROM dbo.Grade AS g
INNER JOIN dbo.Teacher AS t ON g.TeacherID = t.Id
INNER JOIN dbo.Student AS s ON s.Id = g.StudentID
WHERE s.Id < 100
GROUP BY t.FirstName, t.LastName, t.Id
HAVING COUNT(g.Grade) > 50
ORDER BY t.id
GO

SELECT s.Id, s.FirstName, s.LastName, COUNT(g.Grade) AS GradePerStudent, MAX(g.Grade) AS MaxGrade, AVG(Cast(g.Grade AS decimal(5,2)))
FROM dbo.Grade AS g
INNER JOIN dbo.Student AS s ON s.Id = g.StudentID
GROUP BY s.FirstName, s.LastName, s.Id
HAVING MAX(g.Grade) = AVG(Cast(g.Grade AS decimal(5,2)))
ORDER BY s.Id
GO

/*
Requirement 3/3 homework_03
Create new view (vv_StudentGrades) that will List all StudentIds and count of Grades per student
Change the view to show Student First and Last Names instead of StudentID
List all rows from view ordered by biggest Grade Count
Create new view (vv_StudentGradeDetails) that will List all Students (FirstName and LastName) 
and Count the courses he passed through the exam(Ispit)
*/

CREATE VIEW vv_StudentGrades
AS
SELECT s.Id, s.FirstName, s.LastName, COUNT(g.Grade) AS GradePerStudent
FROM dbo.Student AS s
INNER JOIN dbo.Grade AS g ON s.Id = g.StudentID
GROUP BY s.Id, s.FirstName, s.LastName
GO
SELECT *
FROM vv_StudentGrades
GO

ALTER VIEW vv_StudentGrades
AS
SELECT s.FirstName, s.LastName, COUNT(g.Grade) AS GradePerStudent
FROM dbo.Student AS s
INNER JOIN dbo.Grade AS g ON s.Id = g.StudentID
GROUP BY s.FirstName, s.LastName
GO
SELECT *
FROM vv_StudentGrades
GO

SELECT *
FROM vv_StudentGrades AS s
ORDER BY s.GradePerStudent DESC
GO

CREATE OR ALTER VIEW vv_StudentGradeDetails 
AS
SELECT s.Id, s.FirstName + N' ' + s.LastName AS FullName, COUNT(g.CourseID) AS CoursePassed
FROM dbo.GradeDetails AS gd
INNER JOIN dbo.Grade AS g ON gd.GradeID = g.Id
INNER JOIN dbo.Student AS s ON g.StudentID = s.Id
WHERE gd.AchievementTypeID = 5
GROUP BY  s.Id, s.FirstName, s.LastName
GO
SELECT *
FROM vv_StudentGradeDetails
GO
