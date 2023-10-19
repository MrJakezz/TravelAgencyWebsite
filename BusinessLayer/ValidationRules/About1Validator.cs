using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class About1Validator : AbstractValidator<About1>
    {
        public About1Validator()
        {
            RuleFor(x => x.About1Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz.");
            RuleFor(x => x.About1Image).NotEmpty().WithMessage("Lütfen bir görsel seçiniz.");
            RuleFor(x => x.About1Description).MaximumLength(1000).WithMessage("Açıklama 1000 karakterden fazla olamaz.");
        }
    }
}
