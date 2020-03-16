using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class CartItemRepository : ICartitem
    {
        private readonly Mycontext _db;
        public CartItemRepository(Mycontext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.cartItems.Count();
        }

        public void Delete(int id)
        {
            var Caritem = Getbyid(id);
            if (Caritem != null)
            {
                _db.cartItems.Remove(Caritem);
            }
        }

        public IEnumerable<CartItem> Getall()
        {
            return _db.cartItems.Select(c => c);
        }

        public CartItem Getbyid(int id)
        {
            return _db.cartItems.FirstOrDefault(x => x.Cartid == id);
        }

        public void Insert(CartItem cartItem)
        {
            _db.cartItems.Add(cartItem);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CartItem cartItem)
        {
            _db.cartItems.Update(cartItem);
        }
    }
}
