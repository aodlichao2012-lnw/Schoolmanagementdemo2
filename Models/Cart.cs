using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    public class Cart
    {
        [Key]
        public int id { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }

        List<CartItem> CartItems { get; set; }
    }
}
