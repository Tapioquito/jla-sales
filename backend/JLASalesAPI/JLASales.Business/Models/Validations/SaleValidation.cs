using FluentValidation;

namespace JLASales.Business.Models.Validations
{
    public class SaleValidation : AbstractValidator<Sale>
    {
        public SaleValidation()
        {
            RuleFor(a => a.SaleValue).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .GreaterThan(0).WithMessage("O valor da venda deve ser mairo que R$ 0,00");

        }
    }
}
