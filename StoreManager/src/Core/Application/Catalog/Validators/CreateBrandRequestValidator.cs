using FluentValidation;
using StoreManager.Application.Common.Validators;
using StoreManager.Shared.DTOs.Catalog;

namespace StoreManager.Application.Catalog.Validators
{
    public class CreateBrandRequestValidator : CustomValidator<CreateBrandRequest>
    {
        public CreateBrandRequestValidator()
        {
            RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
        }
    }
}