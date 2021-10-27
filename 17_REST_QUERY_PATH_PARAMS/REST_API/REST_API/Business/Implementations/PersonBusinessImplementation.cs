using REST_API.Model;
using System.Collections.Generic;
using REST_API.Repository;
using REST_API.Data.Converter.Implementation;
using REST_API.Data.VO;

namespace REST_API.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;


        private readonly PersonConverter _converter;
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }
        
        // Method responsible for returning all people,
        public List<PersonVO> FindAll()
        {

            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one person by ID
        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }
        
        // Method responsible to crete one new person
        public PersonVO Create(PersonVO person)
        {
            //before call the _coverter.Pase, we have to converter our entity
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }
        
        // Method responsible for updating one perso
        public PersonVO Update(PersonVO person)
        {
            
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        //Mehod responsible for disable a person from an ID
        public PersonVO Disable(long id)
        {
            var personEntity = _repository.Disable(id);
            return _converter.Parse(personEntity);


        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }


    }
}
