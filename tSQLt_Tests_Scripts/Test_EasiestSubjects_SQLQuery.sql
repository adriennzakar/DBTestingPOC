sp_helptext GetEasiestSubjects
GO

CREATE PROCEDURE [TestStoredProcedures].[TestEasiestSubjects]
AS
BEGIN
       EXEC tSQLt.FakeTable 'dbo.Course';
	   EXEC tSQLt.FakeTable 'dbo.StudentGrade';

 INSERT INTO dbo.Course (CourseID, Title, Credits, DepartmentID)
VALUES (1045, 'Calculus', 4, 7);
INSERT INTO dbo.Course (CourseID, Title, Credits, DepartmentID)
VALUES (2030, 'Poetry', 2, 2);
INSERT INTO dbo.Course (CourseID, Title, Credits, DepartmentID)
VALUES (2021, 'Composition', 3, 2);

INSERT INTO dbo.StudentGrade (CourseID, StudentID, Grade)
VALUES (2021, 3, 3);
INSERT INTO dbo.StudentGrade (CourseID, StudentID, Grade)
VALUES (2030, 3, 4);
INSERT INTO dbo.StudentGrade (CourseID, StudentID, Grade)
VALUES (1045, 28, 2.5);

     Create TABLE [TestStoredProcedures].[Actual] 
(
	[CourseID] int NOT NULL,
	[Title] nvarchar (100) NOT NULL,
 )


     Create TABLE [TestStoredProcedures].[Expected] 
(
	[CourseID] int NOT NULL,
	[Title] nvarchar (100) NOT NULL,
 )
 INSERT INTO [TestStoredProcedures].[Expected]   (CourseID, Title)
 VALUES(2030, 'Poetry')

 INSERT INTO [TestStoredProcedures].[Actual]  (CourseID, Title)
 EXEC GetEasiestSubjects;

 EXEC tSQLt.AssertEqualsTable @Expected='TestStoredProcedures.Expected', 
        @Actual='TestStoredProcedures.Actual'
END;
GO

tSQLt.RunAll