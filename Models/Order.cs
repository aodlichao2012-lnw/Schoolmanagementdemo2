using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    public class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }
        [Key]
        public int id { get; set; }
        public int Orderid { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal OrderToTal { get; set; }
        public int Customerid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
