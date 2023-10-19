using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.GuideName).NotEmpty().WithMessage("Lütfen rehber adını giriniz.");
            RuleFor(x => x.GuideDescription).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz.");
            RuleFor(x => x.GuideImage).NotEmpty().WithMessage("Lütfen rehber görselini giriniz.");
        }
    }
}
