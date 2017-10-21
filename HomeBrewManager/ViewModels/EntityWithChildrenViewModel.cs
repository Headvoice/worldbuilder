using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeBrewManager.Models;

namespace HomeBrewManager.ViewModels
{
    public class EntityWithChildrenViewModel
    {

        public HomeBrewEntity Entity { get; set; }
        public List<HomeBrewEntity> Children { get; set; }
    }
}