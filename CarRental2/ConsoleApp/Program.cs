using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Entities;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Brand
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Name="Toyota" });
            //var brand = brandManager.Get(10);
            //brand.Name = "Toyotaa";
            // brandManager.Update(brand);
            //brandManager.Delete(brand);
            //foreach (var brands in brandManager.GetAll())
            //{
            //    Console.WriteLine($"{brands.Id} -- {brands.Name} ");
            //}
            // Console.WriteLine(brandManager.Get(9).Id +" "+brandManager.Get(9).Name );

            #endregion

            #region Color
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { Name = "Yellow" });
            //var color = colorManager.Get(10);
            //color.Name = "Dark Yellow";
            //colorManager.Update(color);
            //colorManager.Delete(color);

            //foreach (var colors in colorManager.GetAll().Data)
            //{
            //    Console.WriteLine($"{colors.Id} -- {colors.Name}");
            //}

            //Console.WriteLine(colorManager.Get(10).Data.Id + " " + colorManager.Get(10).Data.Name);
            #endregion

            #region Car
            //CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId=1,ColorId=1,Description="i 30",ModelYear=DateTime.Now,DailyPrice=180000 });
            //var car = carManager.Get(26);
            //car.Description = "i 30sw";
            //carManager.Update(car);
            //carManager.Delete(car);

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine($"{item.Id} -- {item.ColorId} -- {item.BrandId} -- {item.Description} -- {item.ModelYear} -- {item.DailyPrice}");
            //} 
            #endregion

            #region Car2
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var item in carManager.GetCatDetails().Data)
            //{
            //    Console.WriteLine($"{item.BrandName} -- {item.CarName} -- {item.ColorName} -- {item.DailyPrice} ");
            //} 
            #endregion

            #region Cutomer
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //foreach (var customers in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customers.Id +" -- "+ customers.UserId + " -- " +customers.CompanyName);
            //} 
            #endregion

            #region Rental
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());

            ////foreach (var item in rentalManager.GetAll().Data)
            ////{
            ////    Console.WriteLine(item.Id +" "+ item.CarId+" " +item.CustomerId +" "+item.RentDate +" "+item.ReturnDate);
            ////}
            //Rental rental = new Rental { CarId=10,CustomerId=2,RentDate=DateTime.Now };
            //var rent =  rentalManager.Add(rental);
            //Console.WriteLine(rent.Message); 
            #endregion

            #region RentalDetail
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //foreach (var item in rentalManager.GetByRentDetail().Data)
            //{
            //    Console.WriteLine(+item.RentalId+" "+item.BrandId +" "+item.BrandName +" "+item.CustomerId+" "+item.CompanyName+" "+item.UserId+" "+item.FirstName+" "+item.LastName);
            //} 
            #endregion

        }
    }
}
