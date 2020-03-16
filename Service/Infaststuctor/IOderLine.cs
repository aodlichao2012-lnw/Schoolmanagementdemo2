using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface IOderLine
    {
        IEnumerable<OrderLine> Getall();
        OrderLine Getbyid(int id);
        void Insert(OrderLine orderLine);
        void Update(OrderLine orderLine);
        void Delete(int id);
        int Count();
        void Save();
    }
}
