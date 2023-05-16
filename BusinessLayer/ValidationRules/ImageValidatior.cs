using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidatior : AbstractValidator<Image>
    {
        public ImageValidatior()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçemezsiniz");
            RuleFor(x => x.ImgUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Görsel başlığı en az 5 karakter olabilir");
            RuleFor(x => x.Title).MaximumLength(25).WithMessage("Görsel başlığı en fazla 25 karakter olabilir");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Görsel açıklaması en az 25 karakter olabilir");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Görsel açıklaması en fazla 25 karakter olabilir");
           

        }
    }
}
