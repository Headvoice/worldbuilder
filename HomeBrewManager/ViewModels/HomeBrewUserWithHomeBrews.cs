using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeBrewManager.Models;
namespace HomeBrewManager.ViewModels
{
    public class HomeBrewUserWithHomeBrews
    {
        public HomeBrewUser HomeBrewUser { get; set; }
        public List<HomeBrew> HomeBrews { get; set; }
    }
}