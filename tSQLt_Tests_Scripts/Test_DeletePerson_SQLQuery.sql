sp_helptext DeletePerson
GO

CREATE PROCEDURE [TestStoredProcedures].[TestDeletePerson]
AS
BEGIN
	EXEC tSQLt.FakeTable 'dbo.Person';
 
	INSERT INTO dbo.Person (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
	VALUES (1, 'Pom', 'Pom', '1995-03-12', null, 'Instructor');
	INSERT INTO dbo.Person (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
	VALUES (2, 'Fred', 'Fred', '1996-04-13', null, 'Teacher');

	    Create TABLE [TestStoredProcedures].[Expected] 
 (
	[PersonID] INT,
   [LastName] NVARCHAR(50) NOT NULL,
   [FirstName] NVARCHAR(50) NOT NULL,
   [HireDate] datetime,
   [EnrollmentDate] datetime,
   [Discriminator] NVARCHAR(50) 
 )

 INSERT INTO [TestStoredProcedures].[Expected] (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
 VALUES (1,'Pom', 'Pom', '1995-03-12', null, 'Instructor');
	
	EXEC dbo.DeletePerson 2;
 
 SELECT * INTO TestStoredProcedures.Actual FROM dbo.Person 
 
 EXEC tSQLt.AssertEqualsTable @Expected='TestStoredProcedures.Expected', 
        @Actual='TestStoredProcedures.Actual'
END;
GO
 
EXEC tSQLt.RunAll;