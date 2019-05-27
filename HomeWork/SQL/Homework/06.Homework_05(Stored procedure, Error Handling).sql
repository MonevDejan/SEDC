/*
Requirement 1/3 homework_05
Create new procedure called CreateGrade
Procedure should create only Grade header info (not Grade Details) 
Procedure should return the total number of grades in the system for the Student on input (from the CreateGrade)
Procedure should return second resultset with the MAX Grade of all grades for the Student and Teacher on input (regardless the Course)

*/

CREATE PROCEDURE dbo.CreateGrade 
(@StudentID int, @CourseID smallint, @TeacherID smallint, @Grade tinyint, @Comment nvarchar(255), @CreatedDate date)
AS
BEGIN

INSERT INTO dbo.Grade 
VALUES (@StudentID,  @CourseID,  @TeacherID, @Grade, @Comment, @CreatedDate)

SELECT s.Id, s.FirstName, s.LastName, COUNT(g.Grade) AS TotalGrades
FROM dbo.Grade AS g
INNER JOIN dbo.Student AS s ON s.Id = @StudentID  
WHERE g.StudentID = @StudentID  
GROUP BY s.Id, s.FirstName, s.LastName
ORDER BY s.Id

SELECT s.Id, s.FirstName, s.LastName, MAX(g.Grade) AS MaxGrade
FROM dbo.Grade AS g
INNER JOIN dbo.Student AS s ON s.Id = @StudentID  
WHERE g.StudentID = @StudentID  AND g.TeacherID =  @TeacherID
GROUP BY s.Id, s.FirstName, s.LastName
ORDER BY s.Id
END


EXEC dbo.CreateGrade 
@StudentID = 190,
@CourseID  = 0,
@TeacherID  = 0,
@Grade  = 6,
@Comment = 'Snaodliv',
@CreatedDate = '2000-01-06'
GO

EXEC dbo.CreateGrade 
@StudentID = 190,
@CourseID  = 1,
@TeacherID  = 0,
@Grade  = 7,
@Comment = 'Snaodliv',
@CreatedDate = '2000-01-06'
GO
/*
Requirement 2/3 homework_05
Create new procedure called CreateGradeDetail
Procedure should add details for specific Grade (new record for new AchievementTypeID, Points, MaxPoints, Date for specific Grade)
Output from this procedure should be resultset with SUM of GradePoints calculated with 
formula AchievementPoints/AchievementMaxPoints*ParticipationRate for specific Grade
*/

CREATE PROCEDURE dbo.CreateGradeDetail 
(@GradeID int, @AchievementTypeID int, @AchievementPoints decimal(5,2), 
 @AchievementMaxPoints decimal(5,2), @AchievementDate date)
AS
BEGIN

INSERT INTO dbo.GradeDetails
VALUES (@GradeID, @AchievementTypeID,  @AchievementPoints, @AchievementMaxPoints, @AchievementDate) 

SELECT gd.GradeID, SUM( (gd.AchievementPoints/gd.AchievementMaxPoints) * a.ParticipationRate) AS GradePoints
FROM dbo.GradeDetails AS gd
INNER JOIN dbo.AchievementType AS a ON gd.AchievementTypeID = a.Id
WHERE gd.GradeID = @GradeID
GROUP BY gd.GradeID
ORDER BY gd.GradeID

END
GO

EXEC dbo.CreateGradeDetail
@GradeID = 20122, 
@AchievementTypeID = 0,  
@AchievementPoints = 75.56,
@AchievementMaxPoints = 100.00, 
@AchievementDate = '2019-05-21'
GO

EXEC dbo.CreateGradeDetail
@GradeID = 20123, 
@AchievementTypeID = 5,  
@AchievementPoints = 84.56,
@AchievementMaxPoints = 100.00, 
@AchievementDate = '2019-05-21'
GO


/*
Requirement 3/3 homework_05
Add error handling on CreateGradeDetail procedure
Test the error handling by inserting not-existing values for AchievementTypeID
*/

ALTER PROCEDURE dbo.CreateGradeDetail 
(@GradeID int, @AchievementTypeID int, @AchievementPoints decimal(5,2), 
 @AchievementMaxPoints decimal(5,2), @AchievementDate date)
AS
BEGIN

BEGIN TRY
INSERT INTO dbo.GradeDetails
VALUES (@GradeID, @AchievementTypeID,  @AchievementPoints, @AchievementMaxPoints, @AchievementDate) 

SELECT gd.GradeID, SUM( (gd.AchievementPoints/gd.AchievementMaxPoints) * a.ParticipationRate) AS GradePoints
FROM dbo.GradeDetails AS gd
INNER JOIN dbo.AchievementType AS a ON gd.AchievementTypeID = a.Id
WHERE gd.GradeID = @GradeID
GROUP BY gd.GradeID
ORDER BY gd.GradeID

END TRY

BEGIN CATCH 
SELECT  
    ERROR_NUMBER() AS ErrorNumber  
    ,ERROR_SEVERITY() AS ErrorSeverity  
    ,ERROR_STATE() AS ErrorState  
    ,ERROR_PROCEDURE() AS ErrorProcedure  
    ,ERROR_LINE() AS ErrorLine  
    ,ERROR_MESSAGE() AS ErrorMessage;  
END CATCH
END
GO

EXEC dbo.CreateGradeDetail
@GradeID = 20124, 
@AchievementTypeID = 5,  
@AchievementPoints = 84.56,
@AchievementMaxPoints = 100.00, 
@AchievementDate = '2019-05-21'
GO