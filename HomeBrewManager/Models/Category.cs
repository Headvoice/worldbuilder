using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HomeBrewManager.Models
{
    public class Category
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string CategoryText { get; set; }
    }
}