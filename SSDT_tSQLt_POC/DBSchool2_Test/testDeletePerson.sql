CREATE PROCEDURE [Tests].[testDeletePerson]
AS
BEGIN
	EXEC tSQLt.FakeTable 'dbo.Person';
 
	INSERT INTO dbo.Person (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
	VALUES (1, 'Pom', 'Pom', '1995-03-12', null, 'Instructor');
	INSERT INTO dbo.Person (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
	VALUES (2, 'Fred', 'Fred', '1996-04-13', null, 'Teacher');

	    Create TABLE [Tests].[Expected] 
 (
	[PersonID] INT,
   [LastName] NVARCHAR(50) NOT NULL,
   [FirstName] NVARCHAR(50) NOT NULL,
   [HireDate] datetime,
   [EnrollmentDate] datetime,
   [Discriminator] NVARCHAR(50) 
 )

 INSERT INTO [Tests].[Expected] (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
 VALUES (1,'Pom', 'Pom', '1995-03-12', null, 'Instructor');
	
	EXEC dbo.DeletePerson 2;
 
 SELECT * INTO Tests.Actual FROM dbo.Person 
 
 EXEC tSQLt.AssertEqualsTable @Expected='Tests.Expected', 
        @Actual='Tests.Actual'
END;

GO
