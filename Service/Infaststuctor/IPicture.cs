using E_commere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Infaststuctor
{
    public interface IPicture
    {
        IEnumerable<Picture> Getall();
        Picture Getbyid(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        int Count();
        void Save();
    }
}
