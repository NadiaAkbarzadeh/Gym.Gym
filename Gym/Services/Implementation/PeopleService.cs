using Gym.Models;
using Gym.Repositories.Interface;
using Gym.Services.Interface;

namespace Gym.Services.Implementation
{
    public class PeopleService : IPeopleService
    {
        private readonly IPersonRepository personRepository;

        public PeopleService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public List<Person> GetAllPeople()
        {
            return personRepository.GetAll();
        }

        public Person GetPerson(int id)
        {
            return personRepository.GetPersonById(id);
        }
    }
}
