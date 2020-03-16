using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface IOder
    {
        IEnumerable<Order> Getall();
        Order Getbyid(int id);
        void Insert(Order order);
        void Update(Order order);
        void Delete(int id);
        int Count();
        void Save();
    }
}
