using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookApp.DataAccess.Data;
using BookApp.DataAccess.Repository.IRepository;
using BookApp.Models;

namespace BookApp.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(Company company)
        {
            var objFromDb = _db.Companies.FirstOrDefault(c => c.Id == company.Id);

            if (objFromDb != null) 
            {
                objFromDb.Name = company.Name;
                objFromDb.City = company.City;
                objFromDb.PostalCode = company.PostalCode;
                objFromDb.PhoneNumber = company.PhoneNumber;
                objFromDb.IsAuthorizedCompany = company.IsAuthorizedCompany;
                objFromDb.State = company.State;
                objFromDb.StreetAddress = company.StreetAddress;


            }
        }
    }
}
