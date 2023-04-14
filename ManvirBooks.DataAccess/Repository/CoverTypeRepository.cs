using ManvirBooks.Models;
using ManvirBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManvirBooks.DataAccess.Repository
{
    public class CoverTypeRepository
    {

        private readonly ApplicationDbContext _db;      // get the db instance using the constructor and DI 

        public CoverTypeRepository(ApplicationDbContext db) : base(db)    // use hot keys C-T-O-R to build the constructor
        {
            _db = db;

        }

        public void Update(CoverType covertype)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;
                // _db.SaveChanges();

            }
        }
    }
}
