using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HomeBrewManager.Models
{
    public class HomeBrew
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public List<Bullet> Bullets { get; set; }

        [Display(Name = "Description for Players")]
        public string DescriptionForPlayers { get; set; }

        [Display(Name = "GameMaster Notes")]
        public string GameMasterNotes { get; set; }
        public int HomeBrewUserId { get; set; } //fk
        public HomeBrewUser HomeBrewUser { get; set; }

    }
}