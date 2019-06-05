using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music.Models
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        public string Singer { get; set; }
        public string City { get; set; }
        public string Song { get; set; }
        public string Style { get; set; }
        public string PictureUrl { get; set; }
        
    }
}
