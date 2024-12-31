using CoreBlog.Entities.Concrete;
using FluentValidation;

namespace CoreBlog.Business.ValidationRules.WriterValidation;
public class WriterValidator : AbstractValidator<Writer>
{
    public WriterValidator()
    {
        RuleFor(writer => writer.WriterFullName).NotEmpty().WithMessage("Adı Soyadı Alanı Boş Geçilmemelidir!");
        RuleFor(writer => writer.WriterFullName).MinimumLength(2).WithMessage("Adı Soyadı Alanı En Az 2 Karakter Olmalıdır!");
        RuleFor(writer => writer.WriterFullName).MaximumLength(60).WithMessage("Adı Soyadı Alanı En Çok 60 Karakter Olmalıdır!");

        RuleFor(writer => writer.WriterEmail).NotEmpty().WithMessage("Email Adresi Boş Geçilmemelidir!");

        RuleFor(writer => writer.WriterPassword).NotEmpty().WithMessage("Şifre Alanı Boş Geçilmemelidir!");
    }
}