using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels;

namespace TaskUser.Validator
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {
        public  LoginValidator(IUserService userService, SharedViewLocalizer<LoginValidatorResource> localizer){
            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to250characters"));
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer.GetLocalizedString("vld_'Email'isnotavalidemailaddress."));
            RuleFor(x => x.PassWord).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.PassWord).MaximumLength(50).WithMessage(localizer.GetLocalizedString("vld_maximumlengthof50characters"));
            RuleFor(x => x.PassWord).MinimumLength(8).WithMessage(localizer.GetLocalizedString("vld_minimumlengthof8characters"));
            RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(localizer.GetLocalizedString("vld_passwordmustcontainbothlettersandnumbers."));
        }
    }
}
