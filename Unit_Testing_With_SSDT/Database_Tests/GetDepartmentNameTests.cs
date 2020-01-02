using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Database_Tests
{
    [TestClass()]
    public class GetDepartmentNameTests : SqlDatabaseTestClass
    {

        public GetDepartmentNameTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_GetDepartmentNameTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumGetDepartmentName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountGetDepartmentName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaGetDepartmentName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetDepartmentNameTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetGetDepartmentName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueGetDepartmentName;
            this.dbo_GetDepartmentNameTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_GetDepartmentNameTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumGetDepartmentName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            rowCountGetDepartmentName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            expectedSchemaGetDepartmentName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetGetDepartmentName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            scalarValueGetDepartmentName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_GetDepartmentNameTestData
            // 
            this.dbo_GetDepartmentNameTestData.PosttestAction = null;
            this.dbo_GetDepartmentNameTestData.PretestAction = null;
            this.dbo_GetDepartmentNameTestData.TestAction = dbo_GetDepartmentNameTest_TestAction;
            // 
            // dbo_GetDepartmentNameTest_TestAction
            // 
            dbo_GetDepartmentNameTest_TestAction.Conditions.Add(checksumGetDepartmentName);
            dbo_GetDepartmentNameTest_TestAction.Conditions.Add(rowCountGetDepartmentName);
            dbo_GetDepartmentNameTest_TestAction.Conditions.Add(expectedSchemaGetDepartmentName);
            dbo_GetDepartmentNameTest_TestAction.Conditions.Add(notEmptyResultSetGetDepartmentName);
            dbo_GetDepartmentNameTest_TestAction.Conditions.Add(scalarValueGetDepartmentName);
            resources.ApplyResources(dbo_GetDepartmentNameTest_TestAction, "dbo_GetDepartmentNameTest_TestAction");
            // 
            // checksumGetDepartmentName
            // 
            checksumGetDepartmentName.Checksum = "-397670858";
            checksumGetDepartmentName.Enabled = true;
            checksumGetDepartmentName.Name = "checksumGetDepartmentName";
            // 
            // rowCountGetDepartmentName
            // 
            rowCountGetDepartmentName.Enabled = true;
            rowCountGetDepartmentName.Name = "rowCountGetDepartmentName";
            rowCountGetDepartmentName.ResultSet = 1;
            rowCountGetDepartmentName.RowCount = 1;
            // 
            // expectedSchemaGetDepartmentName
            // 
            expectedSchemaGetDepartmentName.Enabled = true;
            expectedSchemaGetDepartmentName.Name = "expectedSchemaGetDepartmentName";
            resources.ApplyResources(expectedSchemaGetDepartmentName, "expectedSchemaGetDepartmentName");
            expectedSchemaGetDepartmentName.Verbose = false;
            // 
            // notEmptyResultSetGetDepartmentName
            // 
            notEmptyResultSetGetDepartmentName.Enabled = true;
            notEmptyResultSetGetDepartmentName.Name = "notEmptyResultSetGetDepartmentName";
            notEmptyResultSetGetDepartmentName.ResultSet = 1;
            // 
            // scalarValueGetDepartmentName
            // 
            scalarValueGetDepartmentName.ColumnNumber = 1;
            scalarValueGetDepartmentName.Enabled = true;
            scalarValueGetDepartmentName.ExpectedValue = "0";
            scalarValueGetDepartmentName.Name = "scalarValueGetDepartmentName";
            scalarValueGetDepartmentName.NullExpected = false;
            scalarValueGetDepartmentName.ResultSet = 1;
            scalarValueGetDepartmentName.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_GetDepartmentNameTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_GetDepartmentNameTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_GetDepartmentNameTestData;
    }
}
