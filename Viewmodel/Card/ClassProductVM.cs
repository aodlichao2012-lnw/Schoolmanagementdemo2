using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Viewmodel.Card
{
    public class ClassProductVM
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Producttotal { get; set; }
    }
}
