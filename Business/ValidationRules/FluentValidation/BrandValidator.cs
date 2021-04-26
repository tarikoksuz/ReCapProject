using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage("Marka İsmi Boş Geçilemez!"); ;
            RuleFor(b => b.BrandName).MinimumLength(2).WithMessage("Marka İsmi Min:2 Karakter Olmalıdır!");
        }
    }
}
