using Core.DataAccess.EntityFramework;
using DataAccess.Abstruct;
using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetByRentDetail()
        {

            using (ReCapContext db = new ReCapContext())
            {
                var rentList = from r in db.Rentals
                               join c in db.Cars on r.CarId equals c.Id
                               join b in db.Brands on c.BrandId equals b.Id
                               join x in db.Customers on r.CarId equals x.Id
                               join u in db.Users on x.UserId equals u.Id
                               select new RentalDetailDto 
                               {
                                    RentalId=r.Id,
                                    CarId=c.Id,
                                    BrandId=b.Id,
                                    UserId=u.Id,
                                    CustomerId=x.Id,
                                    BrandName=b.Name,
                                    CompanyName=x.CompanyName,
                                    FirstName=u.FirstName,
                                    LastName=u.LastName
                               };


                return rentList.ToList();
            }

        }
    }
}
