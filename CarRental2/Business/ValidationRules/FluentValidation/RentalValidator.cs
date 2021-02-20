using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.CarId).NotNull();
            RuleFor(x => x.CustomerId).NotNull();
            RuleFor(x => x.RentDate).NotNull();
        }
    }
}
