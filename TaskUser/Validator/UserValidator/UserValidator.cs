using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels.UserViewsModels;

namespace TaskUser.Validator.UserValidator
{
  
    public class UserValidator : AbstractValidator<UserViewsModels>
    {
        public  UserValidator(IUserService userService, SharedViewLocalizer localizer){
            var user = userService.Users;
           
            foreach (var users in user)
            {
                RuleFor(x => x.Email).NotEqual(users.Email).WithMessage(localizer.GetLocalizedString("vld_emailalreadyexists")) ; 
            }
            
            RuleFor(x => x.Name).Length(1, 100).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to50characters"));
            RuleFor(x => x.Name).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));;
            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to50characters"));
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty") );
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer.GetLocalizedString("vld_'Email'isnotavalidemailaddress."));
            RuleFor(x => x.PassWord).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.PassWord).MaximumLength(50).WithMessage(localizer.GetLocalizedString("vld_maximumlengthof50characters"));
            RuleFor(x => x.PassWord).MinimumLength(6).WithMessage(localizer.GetLocalizedString("vld_minimumlengthof6characters"));
            RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$")
                .WithMessage(localizer.GetLocalizedString("vld_passwordmustcontainbothlettersandnumbers."));
            RuleFor(x => x.Phone).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));            
            RuleFor(x => x.IsActiver).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
        }
    }
}