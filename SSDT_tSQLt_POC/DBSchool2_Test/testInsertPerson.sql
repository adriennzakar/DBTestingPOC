CREATE PROCEDURE [Tests].[testInsertPerson]
AS
BEGIN
 -- Assemble
        EXEC tSQLt.FakeTable 'dbo.Person', @Identity = 1

    Create TABLE [Tests].[Expected] 
 (
   [LastName] NVARCHAR(50) NOT NULL,
   [FirstName] NVARCHAR(50) NOT NULL,
   [HireDate] datetime,
   [EnrollmentDate] datetime,
   [Discriminator] NVARCHAR(50) 
 )

 INSERT INTO [Tests].[Expected] (LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
 VALUES ('Pom', 'Pom', '1995-03-12', null, 'Instructor');

 -- Act
 EXEC dbo.InsertPerson  'Pom', 'Pom', '1995-03-12', null, 'Instructor'
 SELECT * INTO Tests.Actual FROM dbo.Person 
 
  -- Assert (compare expected table with actual table results)
 EXEC tSQLt.AssertEqualsTable @Expected='Tests.Expected', 
        @Actual='Tests.Actual'
END;

GO
