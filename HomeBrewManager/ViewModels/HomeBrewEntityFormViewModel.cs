using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeBrewManager.Models;
using System.ComponentModel.DataAnnotations;

namespace HomeBrewManager.ViewModels
{
    public class HomeBrewEntityFormViewModel
    {
        [Display(Name = "Category")]
        public IEnumerable<Category> Categories { get; set; }
        public HomeBrewEntity Entity { get; set; }

        public string EntityParentName { get; set; }

    }
}