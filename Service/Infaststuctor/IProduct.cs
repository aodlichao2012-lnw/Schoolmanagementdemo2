using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface IProduct
    {
        IEnumerable<Product> Getall();
        Product Getbyid(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
        int Count();
        void Save();
    }
}
