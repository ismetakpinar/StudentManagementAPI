using FluentValidation;
using StudentManagementAPI.Dtos;

namespace StudentManagementAPI.Validators
{
    public class StudentDtoValidator : AbstractValidator<StudentDto>
    {
        public StudentDtoValidator()
        {
            RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Ad boş olamaz")
            .MinimumLength(2);

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad boş olamaz");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email boş olamaz")
                .EmailAddress().WithMessage("Geçerli bir email giriniz");

            RuleFor(x => x.BirthDate)
                .LessThan(DateTime.Now)
                .WithMessage("Doğum tarihi bugünden büyük olamaz");
        }
    }


}
