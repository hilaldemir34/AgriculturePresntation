using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidatior : AbstractValidator<Team>
    {
        public TeamValidatior()//constructor oluşturdum rulefor kullanabilmek için
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaşı ismini boş geçemezsiniz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz.");
            RuleFor(x => x.imgURL).NotEmpty().WithMessage("Resim boş geçemezsiniz.");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("En fazla 50 karakter yazabilirsiniz"); 
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("En az 5 karakter yazabilirsiniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter yazabilirsiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter yazabilirsiniz");
           
        }
    }
}
