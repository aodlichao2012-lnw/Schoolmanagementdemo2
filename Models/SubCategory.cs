using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    [Table("SubCategory")]
    public class SubCategory
    {
        public int SubCategoryid { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="SubCategoryName")]
        public string SubCategoryName { get; set; }
        public int Categoryid { get; set; }
        public virtual Category Categorys { get; set; }
    }
}
