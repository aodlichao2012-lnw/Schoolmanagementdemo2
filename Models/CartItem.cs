using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    public class CartItem
    {
        [Key]
        public int id { get; set; }
        public int Cartid { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public int? Productid { get; set; }
        public string Customerid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Addate { get; set; }
      
    }
}
