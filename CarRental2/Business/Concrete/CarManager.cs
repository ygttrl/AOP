using Business.Abstruct;
using Business.Constants;
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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidation))]
        public IResult Add(Car car)
        {
            //ValidationTool.Validate(new CarValidation(), car);

            if (car==null)
            {
                return new ErrorResult(Message.ErrorMasage);
            }
            _carDal.Add(car);
            return new SuccessResult(Message.SuccesMassage);
        }

        public IResult Delete(Car car)
        {
            if (car==null)
            {
                return new ErrorResult(Message.ErrorMasage);
            }
            _carDal.Delete(car);
            return new SuccessResult(Message.SuccesMassage);
        }

        [ValidationAspect(typeof(CarValidation))]
        public IResult Update(Car car)
        {
            //ValidationTool.Validate(new CarValidation(), car);
            if (car == null)
            {
                return new ErrorResult(Message.ErrorMasage);
            }
            _carDal.Update(car);
            return new SuccessResult(Message.SuccesMassage);
        }

        public IDataResult<Car> Get(int id)
        {
            if (id<=0)
            {
                return new ErrorDataResult<Car>(Message.ErrorMasage);
            }
          return  new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id),Message.ErrorMasage);
        }

        public IDataResult<List<Car>> GetAll(int brandId)
        {
            if (brandId<=0)
            {
                return new ErrorDataResult<List<Car>>(Message.ErrorMasage);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.BrandId == brandId),Message.SuccesMassage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Message.SuccesMassage);
        }

        public IDataResult<List<CarDetailDto>> GetCatDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Message.SuccesMassage);
        }
    }
}
