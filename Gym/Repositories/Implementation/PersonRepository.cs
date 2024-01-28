using Gym.Models;
using Gym.Repositories.Interface;

namespace Gym.Repositories.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext db;

        public PersonRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void CreatePerson(Person person)
        {
            db.People.Add(person);  
            db.SaveChanges();
        }
        public List<Person> GetAll()
        {
          return  db.People.ToList();
        }
        public Person GetPersonById(int id)
        {
            return db.People.Single(x => x.Id == id);
        }

        public void Update(Person person)
        {

            db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();   
        }
        public void Remove(Person person)
        {

            db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }
    }

}
