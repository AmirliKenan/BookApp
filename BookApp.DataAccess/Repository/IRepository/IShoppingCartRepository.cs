using System;
using System.Collections.Generic;
using System.Text;
using BookApp.Models;

namespace BookApp.DataAccess.Repository.IRepository
{
   public interface IShoppingCartRepository:IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
