using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Validator.StoreValidator
{
    public class StoreValidator:AbstractValidator<StoreViewModels>
    {
     

        public  StoreValidator(IStoreService storeService,IUserService userService,SharedViewLocalizer localizer)
        {
            var store = storeService.Stores;
           
            foreach (var stores in store)
            {
                RuleFor(x => x.Email).NotEqual(stores.Email).WithMessage(localizer.GetLocalizedString("vld_emailalreadyexists")) ;
            }
            var user = userService.Users;
           
            foreach (var users in user)
            {
                RuleFor(x => x.Email).NotEqual(users.Email).WithMessage(localizer.GetLocalizedString("vld_emailalreadyexists")) ; 
            }
                  
       
            RuleFor(x => x.StoreName).Length(1, 100).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to250characters"));
            RuleFor(x => x.StoreName).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to250characters"));
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer.GetLocalizedString("vld_'Email'isnotavalidemailaddress."));
            RuleFor(x => x.Phone).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));  
             
        }
    }
}