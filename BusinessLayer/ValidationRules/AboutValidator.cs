using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutTitle).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz");
            RuleFor(x => x.AboutTitle).MinimumLength(5).WithMessage("En az 5 karakter girişi yapmalısınız.");
            RuleFor(x => x.AboutDescription).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            RuleFor(x => x.AboutImage1).NotEmpty().WithMessage("Resim yükleme kısmını boş geçemezsiniz.");
            RuleFor(x => x.AboutDescription).MinimumLength(10).WithMessage("En az 10 karakter girişi yapmalısınız. ");
        }
    }
}
