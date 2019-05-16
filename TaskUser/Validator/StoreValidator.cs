﻿using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivice;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Validator
{
    public class StoreValidator:AbstractValidator<StoreViewModels>
    {
     

        public  StoreValidator(IStoreService storeService,IUserService userService,SharedViewLocalizer<StoreValidatorResource> localizer)
        {
            RuleFor(x => x.Email).Must((reg, c) => !storeService.IsExistedEmailStore(reg.Id, reg.Email))
                .WithMessage(localizer.GetLocalizedString("vld_notequal"));
            RuleFor(x => x.Email).Must((reg, c) => !userService.IsExistedEmailUser(reg.Id, reg.Email))
                .WithMessage(localizer.GetLocalizedString("vld_notequal"));
            RuleFor(x => x.StoreName).Length(1, 100).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to250characters"));
            RuleFor(x => x.StoreName).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.Email).Length(1, 50).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to250characters"));
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizer.GetLocalizedString("vld_'Email'isnotavalidemailaddress."));
            RuleFor(x => x.Phone).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));  
             
        }
    }
}