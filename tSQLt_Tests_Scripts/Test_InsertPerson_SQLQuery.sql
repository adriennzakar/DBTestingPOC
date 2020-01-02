sp_helptext InsertPerson
GO

CREATE PROCEDURE [TestStoredProcedures].[TestInsertPerson]
AS
BEGIN
 -- Assemble
        EXEC tSQLt.FakeTable 'dbo.Person', @Identity = 1

    Create TABLE [TestStoredProcedures].[Expected] 
 (
   [LastName] NVARCHAR(50) NOT NULL,
   [FirstName] NVARCHAR(50) NOT NULL,
   [HireDate] datetime,
   [EnrollmentDate] datetime,
   [Discriminator] NVARCHAR(50) 
 )

 INSERT INTO [TestStoredProcedures].[Expected] (LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
 VALUES ('Pom', 'Pom', '1995-03-12', null, 'Instructor');

 -- Act
 EXEC dbo.InsertPerson  'Pom', 'Pom', '1995-03-12', null, 'Instructor'
 SELECT * INTO TestStoredProcedures.Actual FROM dbo.Person 
 
  -- Assert (compare expected table with actual table results)
 EXEC tSQLt.AssertEqualsTable @Expected='TestStoredProcedures.Expected', 
        @Actual='TestStoredProcedures.Actual'
END;
GO

tSQLt.RunAll