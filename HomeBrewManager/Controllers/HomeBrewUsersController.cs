using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBrewManager.Models;
using HomeBrewManager.ViewModels;

namespace HomeBrewManager.Controllers
{
    public class HomeBrewUsersController : Controller
    {
        private ApplicationDbContext _context;

        public HomeBrewUsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {

            var users = _context.HomeBrewUsers;


            return View(users);
        }

        public ActionResult Details(int id)
        {
            var user = _context.HomeBrewUsers.SingleOrDefault(e => e.Id == id);
            if (user == null)
                return HttpNotFound();

            return View(user);
        }

        public ActionResult New()
        {


            var user = new HomeBrewUser();



            return View("HomeBrewUserForm", user);

        }

        public ActionResult Edit(int id)
        {
            var homebrewuser = _context.HomeBrewUsers.SingleOrDefault(h => h.Id == id);

            if (homebrewuser == null)
                return HttpNotFound();



            return View("HomeBrewUserForm",homebrewuser);
        }

        [HttpPost]
        public ActionResult Create(HomeBrewUser homebrewuser)
        {
            _context.HomeBrewUsers.Add(homebrewuser);
            _context.SaveChanges();

            return RedirectToAction("Index", "HomeBrewUsers", homebrewuser.Id);

        }



    }

}