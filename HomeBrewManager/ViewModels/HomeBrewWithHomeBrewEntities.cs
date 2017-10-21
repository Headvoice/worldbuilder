using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeBrewManager.Models;
namespace HomeBrewManager.ViewModels
{
    public class HomeBrewWithHomeBrewEntities
    {
        public HomeBrew HomeBrew { get; set; }
        public List<HomeBrewEntity> HomeBrewEntities { get; set;}
    }
}