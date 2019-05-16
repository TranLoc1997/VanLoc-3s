using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels.UserViewsModels;

namespace TaskUser.Validator
{
    public class UserValidator:AbstractValidator<UserViewsModels>
    {
        public  UserValidator(IUserService userService, SharedViewLocalizer<UsersValidatorResource> localizer){
            
            RuleFor(x => x.Email).Must((reg, c) => !userService.IsExistedEmailUser(reg.Id, reg.Email))
                .WithMessage(localizer.GetLocalizedString("vld_notequal"));
            
            RuleFor(x => x.Name).Length(1, 100).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to50characters"));
            RuleFor(x => x.Name).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));;
            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to50characters"));
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty") );
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer.GetLocalizedString("vld_'Email'isnotavalidemailaddress."));
            RuleFor(x => x.Phone).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));            
            RuleFor(x => x.IsActiver).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
        } 
    }
}