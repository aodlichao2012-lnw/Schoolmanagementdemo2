using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class CartegoryRepository : ICartegory
    {
        private readonly Mycontext _db;
        public CartegoryRepository(Mycontext db) 
        {
            _db = db;
        }
        public int Count()
        {
            return _db.categories.Count();
        }

        public void Delete(int id)
        {
            var Categoryitem = Getbyid(id);
            if(Categoryitem != null)
            {
                _db.categories.Remove(Categoryitem);
            }
        }

        public IEnumerable<Category> Getall()
        {
            return _db.categories.Select(c => c);
        }

        public Category Getbyid(int id)
        {
            return _db.categories.FirstOrDefault(x => x.Categoryid == id);
        }

        public void Insert(Category category)
        {
            _db.categories.Add(category);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.categories.Update(category);
        }
    }
}
