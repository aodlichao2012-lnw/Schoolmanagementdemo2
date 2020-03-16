using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface ICartitem
    {
        IEnumerable<CartItem> Getall();
        CartItem Getbyid(int id);
        void Insert(CartItem cartItem);
        void Update(CartItem cartItem);
        void Delete(int id);
        int Count();
        void Save();
    }
}
