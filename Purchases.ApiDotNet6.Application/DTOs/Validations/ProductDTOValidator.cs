using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Application.DTOs.Validations
{
    public class ProductDTOValidator : AbstractValidator<ProductDTO>
    {
        public ProductDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome deve ser informado");

            RuleFor(x => x.CodErp)
               .NotEmpty()
               .NotNull()
               .WithMessage("CodErp deve ser informado");

            RuleFor(x => x.Price)
               .GreaterThan(0)
               .WithMessage("Price deve ser maior que zero");
        }
    }
}
