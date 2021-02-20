using Core.DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstruct
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
