using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Viewmodel.Card
{
    public class CardindexVM
    {
        public CardindexVM()
        {
            classProductVMs = new List<ClassProductVM>();
        }
        public List<ClassProductVM> classProductVMs { get; set; }
        public decimal CardToTalPrice { get; set; }
    }
}
