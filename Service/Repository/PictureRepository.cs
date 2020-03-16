using E_commere.Datacontext;
using E_commere.Models;
using E_commere.Service.Infaststuctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Service.Repository
{
    public class PictureRepository : IPicture
    {
        private readonly Mycontext _db;
        public PictureRepository(Mycontext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.pictures.Count();
        }

        public void Delete(int id)
        {
            var picture = Getbyid(id);
            if (picture != null)
            {
                _db.pictures.Remove(picture);
            }
        }

        public IEnumerable<Picture> Getall()
        {
            return _db.pictures.Select(c => c);
        }

        public Picture Getbyid(int id)
        {
            return _db.pictures.FirstOrDefault(x => x.Pictureid == id);
        }

        public void Insert(Picture picture)
        {
            _db.pictures.Add(picture);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _db.pictures.Update(picture);
        }
    }
}
