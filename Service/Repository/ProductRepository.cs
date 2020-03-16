using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly Mycontext _db;
        public ProductRepository(Mycontext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.products.Count();
        }

        public void Delete(int id)
        {
            var product = Getbyid(id);
            if (product != null)
            {
                _db.products.Remove(product);
            }
        }

        public IEnumerable<Product> Getall()
        {
            return _db.products.Select(c => c);
        }

        public Product Getbyid(int id)
        {
            return _db.products.FirstOrDefault(x => x.Pictureid == id);
        }

        public void Insert(Product product)
        {
            _db.products.Add(product);

        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            _db.products.Update(product);
        }
    }
}
