using FluentValidation;
using LoginProject.Entities;
using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Username).NotEmpty().WithMessage("Kullanıcı Adı boş bırakılamaz.");
            RuleFor(p => p.Username).MinimumLength(5).WithMessage("Kullanıcı Adı en az 5 karakterden oluşmalıdır.");
            RuleFor(p => p.Username).EmailAddress().WithMessage("Kullanıcı Adınız uygun formatta değil.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(p => p.Password).MinimumLength(5).WithMessage("Şifre en az 5 karakterden oluşmalıdır.");
            //RuleFor(p => p.Password).Must(p => p > 99 && p < 10000000).WithMessage("Şifreniz sadece sayılardan oluşabilir.");
        }
    }
}
