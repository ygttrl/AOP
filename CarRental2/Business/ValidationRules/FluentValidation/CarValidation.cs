using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidation : AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(x => x.BrandId).NotNull();
            RuleFor(x => x.ColorId).NotNull();
            RuleFor(x => x.DailyPrice).GreaterThan(0);
            RuleFor(x => x.Description).NotNull().MinimumLength(2).WithMessage("Description En az iki karakter olmalıdır.");
        }
    }
}
