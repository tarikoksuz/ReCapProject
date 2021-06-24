using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(ci => ci.CarImageId).NotEmpty();
            RuleFor(ci => ci.CarId).NotEmpty();
            RuleFor(ci => ci.ImagePath).NotEmpty();
            RuleFor(ci => ci.Date).NotEmpty();
        }
    }
}
