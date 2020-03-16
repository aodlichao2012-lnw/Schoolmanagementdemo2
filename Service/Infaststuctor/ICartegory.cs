using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface ICartegory
    {
        IEnumerable<Category> Getall();
        Category Getbyid(int id);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        int Count();
        void Save();
    }
}
