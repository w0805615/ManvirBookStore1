using ManvirBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManvirBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        void Update(Category category);
       
    }
}