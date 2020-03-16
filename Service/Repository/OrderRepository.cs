using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class OrderRepository : IOder
    {
        private readonly Mycontext _db;
        public OrderRepository(Mycontext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.orders.Count();
        }

        public void Delete(int id)
        {
            var order = Getbyid(id);
            if (order != null)
            {
                _db.orders.Remove(order);
            }
        }

        public IEnumerable<Order> Getall()
        {
            return _db.orders.Select(c => c);
        }

        public Order Getbyid(int id)
        {
            return _db.orders.FirstOrDefault(x => x.Orderid == id);
        }

        public void Insert(Order order)
        {
            _db.orders.Add(order);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Order order)
        {
            _db.orders.Add(order);
        }
    }
}
