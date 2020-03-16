using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    [Table("OrderLine")]
    public class OrderLine
    {
        [Key]
        public int id { get; set; }
        public int OrderLineid { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        [Range(1,100,ErrorMessage ="Price must between {0} to {1}")]
        public decimal? Price { get; set; }
        public int? Orderid { get; set; }
        public int? Productid { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Products { get; set; }
    }
}
