using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    [Table("Picture")]
    public class Picture
    {
        [Key]
        public int id { get; set; }
        public int Pictureid { get; set; }
        [StringLength(100)]
        public string Filename { get; set; }
    }
}
