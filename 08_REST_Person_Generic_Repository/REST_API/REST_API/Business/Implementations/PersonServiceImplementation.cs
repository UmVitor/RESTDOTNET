using REST_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using REST_API.Model.Context;
using REST_API.Repository;

namespace REST_API.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }
        
        // Method responsible for returning all people,
        public List<Person> FindAll()
        {

            return _repository.FindAll();
        }

        // Method responsible for returning one person by ID
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }
        
        // Method responsible to crete one new person
        public Person Create(Person person)
        {
            
            return _repository.Create(person);
        }
        
        // Method responsible for updating one perso
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
        
        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
