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
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext contex = new ReCapContext())
            {
                var carDetailList = from c in contex.Cars
                                    join b in contex.Brands on c.BrandId equals b.Id
                                    join r in contex.Colors on c.ColorId equals r.Id
                                    select new CarDetailDto { CarName=c.Description,BrandName=b.Name,ColorName=r.Name,DailyPrice=c.DailyPrice };

                return carDetailList.ToList();
            }
        }
    }
}
