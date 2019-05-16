using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.ViewsModels.ProductViewsModels;

namespace TaskUser.Validator
{
   
        public class ProductValidator:AbstractValidator<ProductViewsModels>
        {
       
            public  ProductValidator(SharedViewLocalizer<ProductValidatorResource> localizer,IProductSerive productSerive)
            {
                RuleFor(x => x.BrandId).NotNull().WithMessage(localizer.GetLocalizedString("vld_not empty"));
                RuleFor(x => x.CategoryId).NotNull().WithMessage(localizer.GetLocalizedString("vld_not empty"));
                RuleFor(x => x.ListPrice).NotNull().WithMessage(localizer.GetLocalizedString("vld_not empty"));
                RuleFor(x => x.ModelYear).NotNull().WithMessage(localizer.GetLocalizedString("vld_not empty"));
                RuleFor(x => x.PictureFile).NotNull().WithMessage(localizer.GetLocalizedString("vld_not empty"));
                RuleFor(x => x.ProductName).NotNull().WithMessage(localizer.GetLocalizedString("vld_not empty"));
            }
        
        }
    
}