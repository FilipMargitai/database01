using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace database01.Model
{
    public class Animal
    {
        [Key]
        public int AnimId { get; set; }
        [Required]
        public string Species { get; set; } // špatné, ukázka Required

        public string Name { get; set; } // string => nepovinný
        public int? Weight { get; set; } // ? => nepovinný, normální int je povinný
        public bool IsAlive { get; set; }
    }
}
