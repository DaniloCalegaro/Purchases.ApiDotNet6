using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Application.DTOs.Validations
{
    public class PurchaseDTOValidator : AbstractValidator<PurchaseDTO>
    {
        public PurchaseDTOValidator()
        {
            RuleFor(x => x.CodErp)
               .NotEmpty()
               .NotNull()
               .WithMessage("CodErp dever ser informado");

           RuleFor(x => x.Document)
               .NotEmpty()
               .NotNull()
               .WithMessage("Dcomento dever ser informado");
        }
    }
}
