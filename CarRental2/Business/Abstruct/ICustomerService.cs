using Core.Utilities.Result;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Abstruct
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll(int customerId);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int customerId);
        IResult Add(Customer customer);
        IResult Update(Customer Customer);
        IResult Delete(Customer customer );

       
    }
}
