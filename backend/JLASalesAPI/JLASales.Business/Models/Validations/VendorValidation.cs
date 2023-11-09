using FluentValidation;
using static ProductsRegister.Business.Models.Validations.Documents.ValidationDocs;

namespace JLASales.Business.Models.Validations
{
    public class VendorValidation : AbstractValidator<Vendor>
    {
        public VendorValidation()
        {
            RuleFor(v => v.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(3, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(v => v.Document.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
            RuleFor(v => CpfValidacao.Validar(v.Document)).Equal(true)
                .WithMessage("O documento fornecido é inválido.");
        }

    }
}
