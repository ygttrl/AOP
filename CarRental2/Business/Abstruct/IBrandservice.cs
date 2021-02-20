using Core.Utilities.Result;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface IBrandservice
    {
        IDataResult<List<Brand>> GetAll(int brandId);

        IDataResult<List<Brand>> GetAll();

        IResult Add(Brand brand);

        IResult Update(Brand brand);

        IResult Delete(Brand brand);

        IDataResult<Brand> Get(int id);

    }
}
