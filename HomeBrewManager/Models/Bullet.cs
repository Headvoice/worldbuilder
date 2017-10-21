using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HomeBrewManager.Models
{
    public class Bullet
    {
        public int Id { get; set; }

        public string CompositeKey { get; set; }
        public int HomeBrewEntityId { get; set; }

        public short PositionIndex { get; set; }

        [Required]
        [StringLength(150)]
        public string Value { get; set; }

        public bool IsPlayerVisibleBullet { get; set; }
    }
}