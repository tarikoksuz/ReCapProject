using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cst => cst.CompanyName).NotEmpty().WithMessage("Firma İsmi Boş Geçilemez!"); ;
            RuleFor(cst => cst.CompanyName).MinimumLength(2).WithMessage("Firma İsmi Min:2 Karakter Olmalıdır!");
            RuleFor(cst => cst.UserId).NotEmpty();
        }
    }
}
