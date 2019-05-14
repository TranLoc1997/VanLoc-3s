using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels;

namespace TaskUser.Validator.UserValidator
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {
        public  LoginValidator(IUserService userService, SharedViewLocalizer localizer){
            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer["length from 1 to 50 characters"]);
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer["Do not leave"] );
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer["'Email' is not a valid email address."]);
            RuleFor(x => x.PassWord).NotNull().WithMessage(localizer["Do not leave"]);
            RuleFor(x => x.PassWord).MaximumLength(50).WithMessage(localizer["maximum length of 50 characters"]);
            RuleFor(x => x.PassWord).MinimumLength(8).WithMessage(localizer["Minimum length of 8 characters"]);
        }
    }
}
