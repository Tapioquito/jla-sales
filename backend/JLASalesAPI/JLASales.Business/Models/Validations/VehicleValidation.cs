using FluentValidation;

namespace JLASales.Business.Models.Validations
{
    public class VehicleValidation : AbstractValidator<Vehicle>
    {
        public VehicleValidation()
        {
            RuleFor(v => v.ModelName)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(3, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(v => v.ReleaseYear)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(4, 4).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(v => v.Manufacturer)
                .NotEmpty().WithMessage("O campo Fabricante precisa ser fornecido")
                .Length(3, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(v => v.Document)
                .NotEmpty().WithMessage("O campo Renavam precisa ser fornecido")
                .Matches(@"^(\d{3})(\d{3})(\d{3})(\d{2})$").WithMessage("Renavam inválido");
            RuleFor(v => v.LicensePlate)
                .NotEmpty().WithMessage("O campo Placa precisa ser fornecido")
                .Matches(@"[A-Z]{3}[0-9][0-9A-Z][0-9]{2}").WithMessage("Placa inválida");
            RuleFor(v => v.Price)
                .NotEmpty().WithMessage("O campo Preço precisa ser fornecido");
        }
    }
}
