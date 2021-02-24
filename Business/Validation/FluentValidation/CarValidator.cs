using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => Convert.ToInt32(c.ModelYear)).GreaterThanOrEqualTo(2012);
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(180);
            RuleFor(c => c.Description).Must(AtLeastTwoWords).WithMessage("Açıklama en az 2 kelime içermeli");
            RuleFor(c => c.Description).MinimumLength(7);
        }

        private bool AtLeastTwoWords(string arg)
        {
            if (arg.Contains(" "))
            {
                return true;
            }
            return false;
        }
    }
}
