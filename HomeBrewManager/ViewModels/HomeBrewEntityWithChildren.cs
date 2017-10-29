using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeBrewManager.Models;

namespace HomeBrewManager.ViewModels
{
    public class HomeBrewEntityWithChildren
    {

        public HomeBrewEntity Entity { get; set; }
        public IEnumerable<HomeBrewEntity> Children { get; set; }

    }
}