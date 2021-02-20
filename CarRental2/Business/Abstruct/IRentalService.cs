using Core.Utilities.Result;
using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetByCarId(int carId);

        IDataResult<List<Rental>> GetByCustomerId(int customerId);

        IDataResult<List<Rental>> GetAll();

        IDataResult<Rental> Get(int id);

        IResult Add(Rental rental );

        IResult Update(Rental rental);

        IResult Delete(Rental rental);

        IDataResult<List<RentalDetailDto>> GetByRentDetail();
    }
}
