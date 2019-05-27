USE [SEDC_Homework]

DROP TABLE dbo.GradeDetails
DROP TABLE dbo.Grade
DROP TABLE dbo.AchievementType
DROP TABLE dbo.Course
DROP TABLE dbo.Student
DROP TABLE dbo.Teacher
GO

CREATE TABLE [dbo].[Student](
[Id] [int] IDENTITY(1,1) NOT NULL,
[FirstName] [nvarchar](50) NOT NULL,
[LastName]  [nvarchar](50) NOT NULL,
[DateOfBirth] [date] NULL,
[EnrolledDate] [date] NULL,
[Gender] [char] NULL,
[NationalIDNumber] [nvarchar](6) NOT NULL UNIQUE,
[StudentCardNumber] [nvarchar](8) NOT NULL UNIQUE,
CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),

CONSTRAINT [CHK_FullName_Student] CHECK  (LEN(FirstName) > 0  AND  LEN(LastName) > 0), --To not allow empty imput
CONSTRAINT [CHK_NationalIDNumber_Student] CHECK (LEN(NationalIDNumber) = 6), --To same the exat length 
CONSTRAINT [CHK_StudentCardNumber_Student] CHECK (LEN(StudentCardNumber) = 8) --To same the exat length 
)
GO

CREATE TABLE [dbo].[Teacher](
[Id] [smallint] IDENTITY(1,1) NOT NULL,
[FirstName] [nvarchar](50) NOT NULL,
[LastName]  [nvarchar](50) NOT NULL,
[DateOfBirth] [date] NULL ,
[AcademicRank] [nvarchar](20) NOT NULL DEFAULT 'N/A',
[HireDate] [date] NULL,
CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([Id] ASC),
CONSTRAINT [CHK_FullName_Teacher] CHECK  (LEN(FirstName) > 0  AND  LEN(LastName) > 0), --To not allow empty imput
)
GO

CREATE TABLE [dbo].[Course](
[Id] [smallint] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](50) NOT NULL UNIQUE,
[Credit]  [tinyint] NOT NULL DEFAULT 1,
[AcademicYear] [tinyint] NULL,
[Semester] [char] NULL,
CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Id] ASC),

CONSTRAINT [CHK_Name_Course] CHECK  (LEN(Name) > 0), --To not allow empty imput
CONSTRAINT [CHK_Credit_Course] CHECK (Credit BETWEEN 1 AND 12)
)
GO

CREATE TABLE [dbo].[Grade](
[Id] [int] IDENTITY(1,1) NOT NULL,
[StudentID] [int] NOT NULL,
[CourseID] [smallint] NOT NULL,
[TeacherID]  [smallint] NOT NULL,
[Grade] [tinyint] NOT NULL ,
[Comment] [nvarchar] (255) NULL,
[CreatedDate] [date] NULL,
CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED ([Id] ASC),
CONSTRAINT [FK_StudentID_Grade] FOREIGN KEY (StudentID) REFERENCES  dbo.[Student] (ID),
CONSTRAINT [FK_CourseID_Grade] FOREIGN KEY (CourseID) REFERENCES  dbo.[Course] (ID),
CONSTRAINT [FK_TeacherID_Grade] FOREIGN KEY (TeacherID) REFERENCES  dbo.[Teacher] (ID),
CONSTRAINT [CHK_Grade_Grade] CHECK ([Grade] BETWEEN 5 AND 10)
)
GO

CREATE TABLE [dbo].[AchievementType](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](50) NOT NULL,
[Description]  [nvarchar] (255)  NULL,
[ParticipationRate] [decimal](5,2) NULL,
CONSTRAINT [PK_AchievementType] PRIMARY KEY CLUSTERED ([Id] ASC),
CONSTRAINT [CHK_Name_AchievementType] CHECK  (LEN(Name) > 0), --To not allow empty imput
)
GO

CREATE TABLE [dbo].[GradeDetails](
[Id] [int] IDENTITY(1,1) NOT NULL,
[GradeID] [int] NOT NULL,
[AchievementTypeID] [int] NOT NULL,
[AchievementPoints] [decimal](5,2) NULL,
[AchievementMaxPoints] [decimal](5,2) NULL,
[AchievementDate] [date] NULL DEFAULT GETDATE(),
CONSTRAINT [PK_GradeDetails] PRIMARY KEY CLUSTERED ([Id] ASC),

CONSTRAINT [FK_Grade_GradeDetails] FOREIGN KEY (GradeID) REFERENCES dbo.Grade (Id),
CONSTRAINT [FK_AchievementType_GradeDetails] FOREIGN KEY (AchievementTypeID) REFERENCES dbo.AchievementType (Id),

CONSTRAINT [CHK_AchievementPoints_GradeDetails] CHECK (AchievementPoints BETWEEN 0 AND AchievementMaxPoints),
CONSTRAINT [CHK_AchievementMaxPoints_GradeDetails] CHECK (AchievementMaxPoints > 0)
)
GO
