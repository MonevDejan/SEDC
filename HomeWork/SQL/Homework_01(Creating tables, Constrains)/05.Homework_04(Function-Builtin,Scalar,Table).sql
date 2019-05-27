/*
Requirement 1/3 homework_04
Declare scalar variable for storing FirstName values
	Assign value ‘Antonio’ to the FirstName variable
	Find all Students having FirstName same as the variable

Declare table variable that will contain StudentId, StudentName and DateOfBirth
	Fill the table variable with all Female students

Declare temp table that will contain LastName and EnrolledDate columns
	Fill the temp table with all Male students having First Name starting with ‘A’
	Retrieve the students from the table which last name is with 7 characters

Find all teachers whose FirstName length is less than 5 and
	the first 3 characters of their FirstName and LastName are the same
*/
USE [SEDC_Homework]
GO
--------------------------------------------
DECLARE @FirstName nvarchar(50)
SET @FirstName = 'Antonio'

SELECT *
FROM dbo.Student AS s
WHERE s.FirstName = @FirstName
GO
--------------------------------------------

DECLARE @StudentInformation TABLE( StudentId int, StudentName nvarchar(50), DateOfBirth date)

INSERT INTO @StudentInformation 
SELECT s.Id, s.FirstName +  N' ' + s.LastName, s.DateOfBirth
FROM dbo.Student AS s

SELECT * 
FROM @StudentInformation 
GO
--------------------------------------------

CREATE TABLE #StudentTable (LastName nvarchar(50), EnrolledDate date)
GO

INSERT INTO #StudentTable
SELECT s.LastName, s.EnrolledDate
FROM dbo.Student AS s
WHERE s.FirstName like 'A%' AND s.Gender = 'M'
GO

SELECT s.LastName
FROM #StudentTable AS s
GROUP BY s.LastName
HAVING LEN(s.LastName) = 7 
GO
--------------------------------------------

SELECT t.Id, t.FirstName, t.LastName
FROM dbo.Teacher AS t
GROUP BY t.Id, t.FirstName, t.LastName 
HAVING LEN(t.FirstName) < 5 
AND LEFT(t.FirstName, 3) = LEFT(t.LastName, 3)
GO

/*
Requirement 2/3 homework_04
Declare scalar function (fn_FormatStudentName) for retrieving the Student description for specific StudentId in the following format:

StudentCardNumber without “sc-”
“ – “
First character of student FirstName
“.”
Student LastName
*/

CREATE FUNCTION fn_FormatStudentName(@IDStudent int)
RETURNS NVARCHAR(50)
AS
BEGIN 

DECLARE @RESULT nvarchar(50)

SELECT @RESULT = SUBSTRING(s.StudentCardNumber,4, LEN(s.StudentCardNumber)-4) + '-'
		 + LEFT(s.FirstName,1) + '.' +s.LastName
FROM dbo.Student AS s
WHERE s.Id =  @IDStudent 

RETURN  @RESULT
END
GO

SELECT  dbo.fn_FormatStudentName(1)
SELECT  dbo.fn_FormatStudentName(2)
SELECT  dbo.fn_FormatStudentName(3)
SELECT  dbo.fn_FormatStudentName(4)
GO


/*
Requirement 3/3 homework_04
Create multi-statement table value function that for specific Teacher and Course will return 
list of students (FirstName, LastName) who passed the exam, together with Grade and CreatedDate
*/

CREATE FUNCTION fn_PassedStudents (@TeacherID int, @CourseID int)
RETURNS @PassedStudents TABLE(Id int, FirstName nvarchar(50), LastName nvarchar(50), Grade tinyint, CreateDate date)
AS
BEGIN

INSERT INTO @PassedStudents
SELECT s.Id, s.FirstName, s.LastName, g.Grade, g.CreatedDate 
FROM dbo.GradeDetails AS gd
INNER JOIN dbo.Grade AS g ON gd.GradeID = g.Id
INNER JOIN dbo.Student AS s ON g.StudentID = s.Id
WHERE gd.AchievementTypeID = 5 
AND g.TeacherID = @TeacherID 
AND g.CourseID = @CourseID
GROUP BY  s.Id, s.FirstName, s.LastName, g.Grade, g.CreatedDate 

RETURN
END
GO

SELECT *
FROM dbo.fn_PassedStudents(1,1)
GO

