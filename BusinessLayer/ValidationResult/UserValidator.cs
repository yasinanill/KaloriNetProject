using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationResult
{
  public  class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage(" Adı Soyadı Kısmı boş Geçilemez");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("mail  kismi bos gecilemez");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("sifre bos gecilemez");
            RuleFor(x => x.UserPassword).MinimumLength(2).WithMessage("en az iki karakter girisi yapin");
                
        }

    }
}
