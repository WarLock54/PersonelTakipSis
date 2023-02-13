using CarPark.Core.Repository.Abstract;
using CarPark.Entities.concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepository<Personel> _personelRepository;
        public UserController(IRepository<Personel> personelRepository)
        {
            _personelRepository = personelRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {

            

            return View();
        }
    }
}
