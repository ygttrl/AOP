using Core.DataAccess.EntityFramework;
using DataAccess.Abstruct;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal :EfEntityRepositoryBase<Color,ReCapContext>,IColorDal
    {
        
    }
}
