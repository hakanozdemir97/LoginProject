using FluentValidation;
using LoginProject.Entities;
using LoginProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginProject.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Username).NotEmpty().WithMessage("Kullanıcı Adı boş bırakılamaz.");
            RuleFor(p => p.Username).MinimumLength(5).WithMessage("Kullanıcı Adı en az 5 karakterden oluşmalıdır.");
            RuleFor(p => p.Username).EmailAddress().WithMessage("Kullanıcı Adınız uygun formatta değil.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(p => p.Password).Matches("[0-9]+").WithMessage("Parolanız sayısal karakterlerden oluşmalıdır.");


        }
        private bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            return (!lowercase.IsMatch(pw) && !uppercase.IsMatch(pw) && digit.IsMatch(pw) && !symbol.IsMatch(pw) );
        }
    }
}
