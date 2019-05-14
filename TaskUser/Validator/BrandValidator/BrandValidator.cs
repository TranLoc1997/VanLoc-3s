using System.Linq;
using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.ViewsModels.BrandViewsModels;

namespace TaskUser.Validator.BrandValidator
{
    public class BrandValidator:AbstractValidator<BrandViewsModels>
    {
        public BrandValidator(SharedViewLocalizer localizer ,IBrandService  brandService)
        {
            var brands = brandService.Brands;
            foreach (var brand in brands)
            {

                RuleFor(x => x.BrandName).NotEqual(brand.BrandName)
                    .WithMessage(localizer.GetLocalizedString("vld_notequal"));
            }
            RuleFor(x=>x.BrandName).NotNull().WithMessage(localizer.GetLocalizedString("not empty"));
        }
    }
}