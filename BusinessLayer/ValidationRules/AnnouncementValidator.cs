using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.AnnouncementTitle).NotEmpty().WithMessage("Başlık boş bırakılamaz.");
            RuleFor(x => x.AnnouncementContent).NotEmpty().WithMessage("İçerik boş bırakılamaz.");

            RuleFor(x => x.AnnouncementTitle).MinimumLength(5).WithMessage("Başlık 5 karakterden daha kısa olamaz.");
        }
    }
}
