using Business.Abstruct;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstruct;
using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            //ValidationTool.Validate(new RentalValidator(),rental);
            //if (rental==null)
            //{
            //    return new ErrorResult("Rental Eklerken bir hata oluştu.");
            //}
            //_rentalDal.Add(rental);
            //return new SuccessResult("Rental Ekleme başarılı.");

            var rent = _rentalDal.Get(x =>x.CarId==rental.CarId && x.ReturnDate!=null );

            foreach (var item in _rentalDal.GetAll())
            {
                if (item.CarId==rent.CarId && item.ReturnDate==null)
                {
                    return new ErrorResult("Araba henüz iade edilmedi.");
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult("Rental Ekleme başarılı.");

        }

        public IResult Delete(Rental rental)
        {
            if (rental==null)
            {
                return new ErrorResult("Rental Delete işlemi sırasında hata oluştu.");
            }
            _rentalDal.Delete(rental);
            return new SuccessResult("Rental Delete işlemi başarılı.");
        }


        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            //ValidationTool.Validate(new RentalValidator(), rental);

            if (rental== null)
            {
                return new ErrorResult("Rental Update işlemi sırasında hata oluştu.");
            }
            _rentalDal.Update(rental);
            return new SuccessResult("Rental Update işlemi Başarılı.");
        }

        public IDataResult<Rental> Get(int id)
        {
            if (id<=0)
            {
                return new ErrorDataResult<Rental>("Rental Get işlemi sırasında bir hata oluştu.");
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(x =>x.Id==id), "Rental Get işlemi Başarılı");

        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),"Rental İşlemi başarılı.");
        }

        public IDataResult<List<Rental>> GetByCarId(int carId)
        {
            if (carId<=0)
            {
                return new ErrorDataResult<List<Rental>>("Rental GetByCarId işlemi başarısız.");
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.CarId == carId), "Rental GetByCarId işlemi başarılı.");
        }

        public IDataResult<List<Rental>> GetByCustomerId(int customerId)
        {
            if (customerId <= 0)
            {
                return new ErrorDataResult<List<Rental>>("Rental GetByCustomerId işlemi başarısız.");
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.CustomerId == customerId), "Rental GetByCustomerId işlemi başarılı.");
        }

        public IDataResult<List<RentalDetailDto>> GetByRentDetail()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetByRentDetail(),"");
        }
    }
}
