using Gym.Models.Command;

namespace Gym.Services.Interface
{
    public interface ICommandPersonService
    {
        void RegisterPerson(RegisterPersonCommand Command);
        void EditPerson(EditPersonCommand Command);

        void DeletePerson(DeletePersonCommand Command);
    }
}
