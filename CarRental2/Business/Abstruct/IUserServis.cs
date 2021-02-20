using Core.Utilities.Result;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface IUserServis
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetAll(int id);
        IDataResult<User> GetById(int id);
    }
}
