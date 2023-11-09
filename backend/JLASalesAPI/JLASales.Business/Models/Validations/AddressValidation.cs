﻿using FluentValidation;

using JLASales.Business.Models;

namespace ProductsRegister.Business.Models.Validations
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(a => a.StreetName).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa estar entre{MinLenght} e {MaxLength} caracteres.");
            RuleFor(a => a.Neighbourhood).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa estar entre{MinLenght} e {MaxLength} caracteres.");
            RuleFor(a => a.AdditionalInfo).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa estar entre{MinLenght} e {MaxLength} caracteres.");
            RuleFor(a => a.Number).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(1, 50).WithMessage("O campo {PropertyName} precisa estar entre{MinLenght} e {MaxLength} caracteres.");
            RuleFor(a => a.ZipCode).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(8).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres.");
            RuleFor(a => a.City).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(a => a.State).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
    }
}
