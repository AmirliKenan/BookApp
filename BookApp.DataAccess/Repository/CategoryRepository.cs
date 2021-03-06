using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookApp.DataAccess.Data;
using BookApp.DataAccess.Repository.IRepository;
using BookApp.Models;

namespace BookApp.DataAccess.Repository
{
  public  class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (objFromDb != null) 
            {
                objFromDb.Name = category.Name;
 


            }
         
        }
    }
}
