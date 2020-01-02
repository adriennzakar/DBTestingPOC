CREATE PROCEDURE [Tests].[testPersonTableExist]
AS
BEGIN
   EXEC tSQLt.AssertObjectExists 'dbo.Person'
END
GO 
