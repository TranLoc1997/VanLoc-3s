using FluentValidation;
using Microsoft.Extensions.Localization;
using TaskUser.Models;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.ViewsModels;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Validator.StoreValidator
{
    public class EditStoreValidator : AbstractValidator<EditstoreViewModels>
    {
        public  EditStoreValidator(IStoreService storeService, SharedViewLocalizer localizer)
        {
        
            RuleFor(x => x.StoreName).Length(1, 100).WithMessage(localizer.GetLocalizedString("vld_lengthfrom1to250characters"));
            RuleFor(x => x.StoreName).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));
            RuleFor(x => x.Phone).NotNull().WithMessage(localizer.GetLocalizedString("vld_notempty"));  
        }
    }
}