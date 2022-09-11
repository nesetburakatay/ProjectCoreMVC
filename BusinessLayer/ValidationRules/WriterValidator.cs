using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotNull().WithMessage("Kullanıcı ismi boş olamaz");
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Kullanıcı ismi boş olamaz");
            RuleFor(x => x.WriterName).MaximumLength(10).WithMessage("Kullanıcı karakteri en fazla 10 karakter olabilir.");

            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçerli bir mail adresi girin");

        }
    }
}
