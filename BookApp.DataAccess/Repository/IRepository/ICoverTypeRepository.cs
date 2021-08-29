using System;
using System.Collections.Generic;
using System.Text;
using BookApp.Models;

namespace BookApp.DataAccess.Repository.IRepository
{
  public  interface ICoverTypeRepository:IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
