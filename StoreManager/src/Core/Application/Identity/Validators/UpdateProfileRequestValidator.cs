using FluentValidation;
using StoreManager.Application.Common.Validators;
using StoreManager.Application.Storage;
using StoreManager.Shared.DTOs.Identity;

namespace StoreManager.Application.Validators.Identity
{
    public class UpdateProfileRequestValidator : CustomValidator<UpdateProfileRequest>
    {
        public UpdateProfileRequestValidator()
        {
            RuleFor(p => p.FirstName).MaximumLength(75).NotEmpty();
            RuleFor(p => p.LastName).MaximumLength(75).NotEmpty();
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Image).SetValidator(new FileUploadRequestValidator());
        }
    }
}