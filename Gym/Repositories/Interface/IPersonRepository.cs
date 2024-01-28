using Gym.Models;

namespace Gym.Repositories.Interface
{
    public interface IPersonRepository
    {
        void CreatePerson(Person person);
        List<Person> GetAll();

        Person GetPersonById(int id);
        void Update(Person person);
        void Remove(Person person); 
    }
}
