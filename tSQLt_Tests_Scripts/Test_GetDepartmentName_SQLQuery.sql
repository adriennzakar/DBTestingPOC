sp_helptext GetDepartmentName;

DECLARE @Name varchar(50)
EXEC GetDepartmentName 2 , @Name Output
SELECT @Name;
GO

CREATE PROCEDURE [TestStoredProcedures].[TestGetDepartmentName]
AS
BEGIN

EXEC tSQLt.FakeTable 'dbo.Department';

INSERT INTO dbo.Department (DepartmentID, [Name], Budget, StartDate, Administrator)
VALUES (1, 'Engineering', 350000.00, '2007-09-01', 2);
INSERT INTO dbo.Department (DepartmentID, [Name], Budget, StartDate, Administrator)
VALUES (2, 'English', 120000.00, '2007-09-01', 6);

DECLARE @ExpectedName varchar(50)
SET @ExpectedName = 'English'
DECLARE @ActualName varchar(50)
EXEC GetDepartmentName 2 , @ActualName Output
SELECT @ActualName;

 EXEC tSQLt.AssertEquals @ExpectedName, 
        @ActualName
END;
GO

tSQLt.RunAll