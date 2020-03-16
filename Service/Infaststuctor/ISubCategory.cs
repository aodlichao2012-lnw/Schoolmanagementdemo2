using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> Getall();
        SubCategory Getbyid(int id);
        void Insert(SubCategory subCategory);
        void Update(SubCategory subCategory);
        void Delete(int id);
        int Count();
        void Save();
    }
}
