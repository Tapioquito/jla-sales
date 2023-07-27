using FluentValidation;
using JLASales.Business.Models;
using JLASales.Business.Valdations.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JLASales.Business.Valdations
{
    public class VehicleValidation : AbstractValidator<Vehicle>
    {
        public VehicleValidation()
        {
            RuleFor(v => v.ModelName)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            RuleFor(v => v.MotorPower)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
               
            RuleFor(v => v.Document)//RENAVAM
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Matches(@"^[0-9]{11}$").WithMessage("O campo {PropertyName} é inválido");
            RuleFor(v => v.ReleaseYear)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(4, 4).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(v => v.Manufacturer)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(v => v.MotorPower)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(v => v.LicensePlate)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Matches(@"[A-Z]{2,3}[0-9]{4}|[A-Z]{3,4}[0-9]{3}|[A-Z0-9]{7}").WithMessage("O campo {PropertyName} é inválido");
            
            RuleFor(v=>v.Price)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                 .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");

           
        }

    }
}
