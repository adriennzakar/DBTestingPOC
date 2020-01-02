using InMemory_Db_Tests.Models;
using InMemory_Db_Tests.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        private DbContextOptions<School2Context> options;

        [TestInitialize]
        public void TestInitialization()
        {

            options = new DbContextOptionsBuilder<School2Context>()
                .UseInMemoryDatabase(databaseName: "InMemoryTestDb")
                .Options;

            using (var context = new School2Context(options))
            {
                var repository = new PersonRepository(context);
                if (context.Person.Count() == 0)
                {
                    repository.Add("TestStudent", "Test", null, null, "Student");
                }
            }
        }

        [TestMethod]
        public void TestAddPerson()
        {
            using (var context = new School2Context(options))
            {
                 Assert.AreEqual(1, context.Person.Count());
                 Assert.AreEqual("TestStudent", context.Person.Single().LastName);

                var repository = new PersonRepository(context);
            }
        }

        [TestMethod]
        public void TestGetInstructors()
        {
            using (var context = new School2Context(options))
            {
                var repository = new PersonRepository(context);
                repository.Add("TestInstructor", "Test", null, null, "Instructor");
            }

            using (var context = new School2Context(options))
            {
                var repository = new PersonRepository(context);
                var insructors = repository.GetInstructors();

                Assert.AreEqual(1, insructors.Count());
                Assert.AreEqual("TestInstructor", insructors.First().LastName);
            }
        }

        [TestMethod]
        public void TestDeletePerson()
        {
            using (var context = new School2Context(options))
            {
                var repository = new PersonRepository(context);
                repository.Delete(1);

                Assert.AreEqual(0, context.Person.Count());
            }
        }
    }
}
