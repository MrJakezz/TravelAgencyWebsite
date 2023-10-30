using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.AnnouncementTitle).NotEmpty().WithMessage("Başlık boş bırakılamaz.");
            RuleFor(x => x.AnnouncementContent).NotEmpty().WithMessage("İçerik boş bırakılamaz.");

            RuleFor(x => x.AnnouncementTitle).MinimumLength(5).WithMessage("Başlık 5 karakterden daha kısa olamaz.");
        }
    }
}
