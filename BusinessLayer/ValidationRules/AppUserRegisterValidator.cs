using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş bırakılamaz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim boş bırakılamaz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş bırakılamaz.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı boş bırakılamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifreyi tekrar yazınız.");

            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı Adı 5 karakterden daha kısa olamaz.");
            RuleFor(x => x.Username).MaximumLength(25).WithMessage("Kullanıcı Adı 25 karakterden daha uzun olamaz.");

            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor.");
        }
    }
}
