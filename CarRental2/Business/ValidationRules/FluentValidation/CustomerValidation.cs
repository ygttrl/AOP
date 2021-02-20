using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.CompanyName).NotNull();
            RuleFor(x => x.CompanyName).MinimumLength(2);
        }
    }
}
