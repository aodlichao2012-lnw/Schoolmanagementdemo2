using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly Mycontext _db;
        public SubCategoryRepository(Mycontext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.subCategories.Count();
        }

        public void Delete(int id)
        {
            var subcategory = Getbyid(id);
            if (subcategory != null)
            {
                _db.subCategories.Remove(subcategory);
            }
        }

        public IEnumerable<SubCategory> Getall()
        {
            return _db.subCategories.Select(c => c);
        }

        public SubCategory Getbyid(int id)
        {
            return _db.subCategories.FirstOrDefault(x => x.Categoryid == id);
        }

        public void Insert(SubCategory subCategory)
        {
            _db.subCategories.Add(subCategory);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _db.subCategories.Update(subCategory);
        }
    }
}
