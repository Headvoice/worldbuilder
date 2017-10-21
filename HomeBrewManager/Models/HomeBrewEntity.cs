using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HomeBrewManager.Models
{
    public class HomeBrewEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int ParentId { get; set; }
        public HomeBrew HomeBrew { get; set; } //nav prop
        public int HomeBrewId { get; set; } //fk


        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; } //fk

        public Category Category { get; set; } //nav prop

        //public List<Bullet> Bullets { get; set; }

        [Display(Name = "Description for Players")]
        public string DescriptionForPlayers { get; set; }

        [Display(Name = "GameMaster Notes")]
        public string GameMasterNotes { get; set; }
    }
}