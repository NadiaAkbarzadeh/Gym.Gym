using Gym.Models;
using Gym.Repositories.Interface;

namespace Gym.Repositories.Implementation
{
    public class SportTypeRepository : ISportTypeRepository
    {
        private readonly ApplicationDbContext db;

        public SportTypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Create(SportType sportType)
        {
           db.SportTypes.Add(sportType);
            db.SaveChanges();
        }

        public IList<SportType> GetAllSporType()
        {
            return db.SportTypes.ToList();
        }
    }
}
