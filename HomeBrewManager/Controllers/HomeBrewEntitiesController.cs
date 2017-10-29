using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBrewManager.Models;
using HomeBrewManager.ViewModels;
//using MoreLinq;
namespace HomeBrewManager.Controllers
{
    public class HomeBrewEntitiesController : Controller
    {
        private ApplicationDbContext _context;

        public HomeBrewEntitiesController()
        {
            _context = new ApplicationDbContext();
            //new comment
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {

            var entities = _context.HomeBrewEntities;


            return View(entities);
        }

        public ActionResult Details(int id)
        {

            var ent = _context.HomeBrewEntities.SingleOrDefault(e => e.Id == id);
            if (ent == null)
                return HttpNotFound();

            
            var entchildren = from e in _context.HomeBrewEntities
                           where e.ParentId == ent.Id
                           select e;

            var vm = new HomeBrewEntityWithChildren()
            {
                Entity = ent,
                Children = entchildren
            };
          

            return View(vm);
        }

        public ActionResult New(int homebrewid, int parentid)
        {

            var entity = new HomeBrewEntity()
            {
                ParentId = parentid,
                HomeBrewId = homebrewid
            };

            //needs to take into account that parent can be a homebrew, in which case parent should be null.
            var categories = _context.Categories.ToList();
            var vm = new HomeBrewEntityFormViewModel()
            {
                Categories = categories,
                Entity = entity,

            };
            if (parentid == homebrewid)
            {
                var homebrewInDb = _context.HomeBrews.Single(p => p.Id == homebrewid);
                vm.EntityParentName = homebrewInDb.Name;
            }
            else
            {
                var hbentityInDb =_context.HomeBrewEntities.Single(p => p.Id == parentid);
                vm.EntityParentName = hbentityInDb.Name;

            }



            return View("HomeBrewEntityForm", vm);
        }
        public ActionResult Save(HomeBrewEntityFormViewModel vm)
        {
            var homebrewentity = vm.Entity;

            if (homebrewentity.Id == 0)
            {
                _context.HomeBrewEntities.Add(homebrewentity);

            }
            else
            {
                var hbEntityInDb = _context.HomeBrewEntities.Single(h => h.Id == homebrewentity.Id);
                    hbEntityInDb.Name = homebrewentity.Name;
                hbEntityInDb.GameMasterNotes = homebrewentity.GameMasterNotes;
                hbEntityInDb.DescriptionForPlayers = homebrewentity.DescriptionForPlayers;

            }

            _context.SaveChanges();

            if (homebrewentity.ParentId == homebrewentity.HomeBrewId)
            {
                return RedirectToAction("Details", "HomeBrews", new { id = homebrewentity.HomeBrewId });

            }
            else
            {
                return RedirectToAction("Details", "HomeBrewEntities", new { id = homebrewentity.ParentId });

            }

        }

        public ActionResult Edit(int id)
        {
            var homebrewentity = _context.HomeBrewEntities.SingleOrDefault(h => h.Id == id);

            if (homebrewentity == null)
                return HttpNotFound();

            var vm = new HomeBrewEntityFormViewModel
            {
                Categories = _context.Categories.ToList(),
                Entity = homebrewentity
            };

            return View("HomeBrewEntityForm", vm);
        }

        [HttpPost]
        public ActionResult Create(HomeBrewEntity homebrewentity)
        {

            if (homebrewentity.Id == 0)
            {
                _context.HomeBrewEntities.Add(homebrewentity);

            }
            else
            {
                var homebrewentityInDb = _context.HomeBrewEntities.Single(h => h.Id == homebrewentity.Id);

                homebrewentityInDb.Name = homebrewentity.Name;
                homebrewentityInDb.DescriptionForPlayers = homebrewentity.DescriptionForPlayers;
                homebrewentityInDb.GameMasterNotes = homebrewentity.GameMasterNotes;
            }
            _context.SaveChanges();


            return RedirectToAction("Details", "HomeBrewEntities", homebrewentity.ParentId);
        }




        [Route("entities/category/{category:maxlength(25)}")]
        public ActionResult ByCategory(int category)
        {
            return Content(string.Format("Category={0}", category));
        }
        public ActionResult Random()
        {
            var entity = new HomeBrewEntity() { Name = "Loridon" };

            var children = new List<HomeBrewEntity>
            {
                new HomeBrewEntity() {Name="Child1"},
                new HomeBrewEntity() {Name="Child2"}
            };

            var vm = new EntityWithChildrenViewModel()
            {
                Entity = entity,
                Children = children
            };

            return View(vm);
            //           return Content("Test with a string");
        }


    }
}