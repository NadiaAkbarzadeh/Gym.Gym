using Gym.Models;
using Gym.Models.Command;
using Gym.Repositories.Interface;
using Gym.Services.Interface;

namespace Gym.Services.Implementation
{
    public class CommandPersonService : ICommandPersonService

    {
        private readonly IPersonRepository personRepository;

        public CommandPersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public void RegisterPerson(RegisterPersonCommand Command)
        {
            var person = new Person()
            {
                FirstName = Command.FirstName,
                LastName = Command.LastName,
                BirthDate = Command.BirthDate,
                Address = Command.Address,
                Height = Command.Height,
                Weight = Command.Weight,
                Mobile = Command.Mobile,
                NationalCode = Command.NationalCode,
                PhoneNumber = Command.PhoneNumber,
            };
            personRepository.CreatePerson(person);
        }
        public void EditPerson(EditPersonCommand Command)
        {
           var person= personRepository.GetPersonById(Command.Id);

            person.FirstName = Command.FirstName;
            person.LastName = Command.LastName;
            person.BirthDate = Command.BirthDate;
            person.Weight = Command.Weight;
            person.Height = Command.Height;
            person.PhoneNumber = Command.PhoneNumber;
            person.Mobile = Command.Mobile;
            person.NationalCode = Command.NationalCode;
            person.Address = Command.Address;
            personRepository.Update(person);


        }
        public void DeletePerson(DeletePersonCommand Command)
        {
            var person = personRepository.GetPersonById(Command.Id);

            person.Id = Command.Id;
            
            personRepository.Remove(person);
            
        }
    }
}
