using Core.Utilities.Result;
using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(int carId);
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> Get(int id);
        IDataResult<List<CarDetailDto>> GetCatDetails();
    }
}
