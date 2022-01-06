using FluentValidation;
using StoreManager.Application.Common.Validators;
using StoreManager.Shared.DTOs.Catalog;

namespace StoreManager.Application.Catalog.Validators
{
    public class UpdateBrandRequestValidator : CustomValidator<UpdateBrandRequest>
    {
        public UpdateBrandRequestValidator()
        {
            RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
        }
    }
}