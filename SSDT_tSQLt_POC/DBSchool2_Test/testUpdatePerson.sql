CREATE PROCEDURE [Tests].[testUpdatePerson]
AS
BEGIN
	EXEC tSQLt.FakeTable 'dbo.Person';
 
	INSERT INTO dbo.Person (PersonID, LastName, FirstName, HireDate, EnrollmentDate, Discriminator)
	VALUES (1, 'Pom', 'Pom', '1995-03-12', null, 'Instructor');
	
	EXEC dbo.UpdatePerson 1, 'NewPom', 'Pom', '1995-03-12', null, 'Instructor';
 
  DECLARE @NewLastName nvarchar(50)
  SELECT @NewLastName = LastName FROM dbo.Person WHERE PersonID = 1;
 
  EXEC tSQLt.AssertEquals 'NewPom', @NewLastName;
END;

GO
