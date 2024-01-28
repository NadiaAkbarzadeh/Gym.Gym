using Gym.Models;

namespace Gym.Repositories.Interface
{

    public interface ISportTypeRepository
    {
        void Create(SportType sportType);
        IList<SportType> GetAllSporType();
    }

}

