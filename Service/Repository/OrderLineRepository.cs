using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class OrderLineRepository : IOderLine
    {
        private readonly Mycontext _db;
        public OrderLineRepository(Mycontext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.orderLines.Count();
        }

        public void Delete(int id)
        {
            var OrderLine = Getbyid(id);
            if (OrderLine != null)
            {
                _db.orderLines.Remove(OrderLine);
            }
        }

        public  IEnumerable<OrderLine> Getall()
        {
            return _db.orderLines.Select(c => c);
        }

        public OrderLine Getbyid(int id)
        {
            return _db.orderLines.FirstOrDefault(x => x.OrderLineid == id);
        }

        public void Insert(OrderLine orderLine)
        {
            _db.orderLines.Add(orderLine);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(OrderLine orderLine)
        {
            _db.orderLines.Update(orderLine);
        }
    }
}
