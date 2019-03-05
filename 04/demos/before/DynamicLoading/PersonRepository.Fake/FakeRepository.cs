using PersonRepository.Interface;
using System;
using System.Collections.Generic;

namespace PersonRepository.Fake
{
    public class FakeRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            IEnumerable<Person> people = new List<Person>() {
                new Person()
                {
                    Id=1,GivenName="Dave",FamilyName="Bartlett",Rating=4,StartDate= new DateTime(2000,5,6)
                },
                new Person()
                {
                    Id=2,GivenName="Mark",FamilyName="Morris",Rating=8,StartDate= new DateTime(2001,1,9)
                }
            };
            return people;
        }
        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
