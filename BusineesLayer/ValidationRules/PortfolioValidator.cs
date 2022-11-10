using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Length must be minimum 5 characters");
            RuleFor(x => x.Name).MaximumLength(12).WithMessage("Length must be maximum 12 characters");
        }
    }
}
