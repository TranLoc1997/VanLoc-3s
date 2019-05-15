using FluentValidation;
using Microsoft.Extensions.Localization;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels;

namespace TaskUser.Validator.UserValidator
{
    public class PasswordValidator : AbstractValidator<EditViewPassword>
    {
        public  PasswordValidator(IUserService userService,SharedViewLocalizer<PasswordValidatorResource> localizer)
        {
            RuleFor(x => x.NewPassword).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.NewPassword).MaximumLength(50).WithMessage(localizer.GetLocalizedString("vld_maximumlengthof50characters"));
            RuleFor(x => x.NewPassword).MinimumLength(6).WithMessage(localizer.GetLocalizedString("vld_minimumlengthof6characters"));
            RuleFor(x => x.NewPassword).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(localizer.GetLocalizedString("vld_passwordmustcontainbothlettersandnumbers."));
            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.ConfirmPassword).MaximumLength(50).WithMessage(localizer.GetLocalizedString("vld_maximumlengthof50characters"));
            RuleFor(x => x.ConfirmPassword).MinimumLength(6).WithMessage(localizer.GetLocalizedString("vld_minimumlengthof6characters"));
            RuleFor(x => x.NewPassword).Equal(x => x.ConfirmPassword)
                .WithMessage(localizer.GetLocalizedString("vld_confirmpasswordmustbeequalnewPassword"));

        }
        
    }
    
}

