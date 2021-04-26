using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(cl => cl.ColorName).NotEmpty().WithMessage("Renk İsmi Boş Geçilemez!");
            RuleFor(cl => cl.ColorName).MinimumLength(2).WithMessage("Renk İsmi Min:2 Karakter Olmalıdır!");
        }
    }
}
