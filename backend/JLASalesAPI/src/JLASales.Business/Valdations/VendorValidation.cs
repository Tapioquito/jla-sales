using FluentValidation;
using JLASales.Business.Models;
using JLASales.Business.Valdations.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Business.Valdations
{
    public class VendorValidation : AbstractValidator<Vendor>
    {

        public VendorValidation()
        {
            RuleFor(f => f.Name)
                   .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                   .Length(2, 100)
                   .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");


            RuleFor(f => f.Document.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

            RuleFor(f => CpfValidacao.Validar(f.Document)).Equal(true)
                .WithMessage("O documento fornecido é inválido.");

        }
    }
}
