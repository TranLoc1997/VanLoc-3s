using FluentValidation;
using TaskUser.Resources;
using TaskUser.Service;
using TaskUser.ViewsModels.ProductViewsModels;

namespace TaskUser.Validator
{
   
        public class ProductValidator:AbstractValidator<ProductViewsModels>
        {
       
            public  ProductValidator(SharedViewLocalizer<ProductValidatorResource> localizer,IProductService productSerive)
            {
                RuleFor(x => x.BrandId).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
                RuleFor(x => x.CategoryId).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
                RuleFor(x => x.ListPrice).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
                RuleFor(x => x.ModelYear).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
                RuleFor(x => x.PictureFile).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
                RuleFor(x => x.ProductName).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));
            }
        
        }
    
}