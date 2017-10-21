using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBrewManager.Models;
using HomeBrewManager.ViewModels;
namespace HomeBrewManager.Controllers
{
    public class HomeBrewsController : Controller
    {
        private ApplicationDbContext _context;

        public HomeBrewsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {

            var entities = _context.HomeBrews;


            return View(entities);
        }

        public ActionResult ForUser(int userid)
        {

            var user = _context.HomeBrewUsers.SingleOrDefault(u => u.Id == userid);
            
                if (user == null)
                    return HttpNotFound();


            var homebrews = _context.HomeBrews.Where(u => u.HomeBrewUserId == userid).ToList();

            var vm = new HomeBrewUserWithHomeBrews()
            {

                HomeBrewUser = user,
                HomeBrews = homebrews

            };
            return View("HomeBrewsForUser",vm);
        }
        public ActionResult Details(int id)
        {
            var homebrew = _context.HomeBrews.SingleOrDefault(e => e.Id == id);
            if (homebrew == null)
                return HttpNotFound();

            var childentities = _context.HomeBrewEntities.Where(c => c.HomeBrewId == homebrew.Id).ToList();

            var vm = new HomeBrewWithHomeBrewEntities()
            {
                HomeBrew = homebrew,
                HomeBrewEntities = childentities
            };

            return View(vm);
        }

        public ActionResult New(int userid)
        {

            var homebrew = new HomeBrew()
            {
                HomeBrewUserId = userid
            };
            return View("HomeBrewForm", homebrew);
        }
        public ActionResult Save(HomeBrew homebrew)
        {
            if (homebrew.Id==0)
            {
                _context.HomeBrews.Add(homebrew);
        

            }
            else
            {
                var homebrewInDb = _context.HomeBrews.Single(h => h.Id == homebrew.Id);
                homebrewInDb.Name = homebrew.Name;
                homebrewInDb.DescriptionForPlayers = homebrew.DescriptionForPlayers;
                homebrewInDb.GameMasterNotes = homebrew.GameMasterNotes;
            }
            _context.SaveChanges();
            return RedirectToAction("foruser", "HomeBrews", new { userid = homebrew.HomeBrewUserId });
        }
    }


}