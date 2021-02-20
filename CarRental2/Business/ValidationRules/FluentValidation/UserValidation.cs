using Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.FirstName).MinimumLength(2);

            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.LastName).MinimumLength(2);

            RuleFor(x => x.Email).Must(Contain);
            RuleFor(x => x.Password).MinimumLength(3);
        }

        private bool Contain(string arg)
        {
            return arg.Contains("@");
        }
    }
}
