using Gym.Models;

namespace Gym.Services.Interface
{
    public interface IPeopleService
    {
        List<Person> GetAllPeople();
        Person GetPerson(int id);
    }
}
