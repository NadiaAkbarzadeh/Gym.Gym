
using Gym.Models;
using Gym.Repositories.Implementation;
using Gym.Repositories.Interface;
using Gym.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Cache;

namespace Gym.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISportTypeRepository sportTypeRepository;
        private readonly ApplicationDbContext db;

        public HomeController (ISportTypeRepository sportTypeRepository , ApplicationDbContext db)
            {
            this.sportTypeRepository = sportTypeRepository;
            this.db = db;
        }
        public IActionResult Index()
        {
            //{
            //    Address = "Tabriz",
            //    Age = 31,
            //    Balance = 40_000,
            //    BirthDate = new DateTime(1990, 07, 31),
            //    FirstName = "Nadia",
            //    LastName = "Akbarzadeh",
            //    Height = 160,
            //    Weight = 56,
            //    Mobile = "+989364878895",
            //    NationalCode = "1360452672",
            //    PhoneNumber = "+989364878895",
            //};
            //db.People.Add(person);
            //db.SaveChanges();

            //var teacher = new Teacher()
            //{
            //    Address = "Tabriz",
            //    Age = 31,
            //    Balance = 40_000,
            //    BirthDate = new DateTime(1990, 07, 31),
            //    FirstName = "Nadia",
            //    LastName = "Akbarzadeh",
            //    Height = 160,
            //    Weight = 56,
            //    Mobile = "+989364878895",
            //    NationalCode = "1360452672",
            //    PhoneNumber = "+989364878895",
            //    NumberOfChilds=0,
            //};
            //db.People.Add(teacher);
            //db.SaveChanges();


            //var person = new Person();
            //person.BirthDate = new DateTime(1990, 07, 31);

            //var sportType = new SportType { Name = "BodyBulding" };
            //sportTypeRepository.Create(sportType);

            return View();

            //IActionResult Index()
            //{
            //    //return View(person);
            //}
        }
    }
}