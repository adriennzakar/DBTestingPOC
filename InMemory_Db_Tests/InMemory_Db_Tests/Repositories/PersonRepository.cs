using InMemory_Db_Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InMemory_Db_Tests.Repositories
{
    public class PersonRepository
    {
        private School2Context _context;

        public PersonRepository(School2Context context)
        {
            _context = context;
        }

        public void Add(string lastName, string firstName, DateTime? hireDate, DateTime? enrollmentDate, string discriminator)
        {
            var person = new Person { LastName = lastName, FirstName = firstName, HireDate = hireDate, EnrollmentDate = enrollmentDate, Discriminator = discriminator };
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public IEnumerable<Person> GetInstructors()
        {
            return _context.Person
                .Where(b => b.Discriminator == "Instructor")
                .OrderBy(b => b.FirstName)
                .ToList();
        }

        public void Delete(int ID)
        {
            var person = _context.Person
                .Where(p => p.PersonId == ID).FirstOrDefault();
            _context.Person.Remove(person);
            _context.SaveChanges();
        }
    }
}
