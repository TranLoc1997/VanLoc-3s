using FluentValidation;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.BrandViewsModels;

namespace TaskUser.Validator
{
    public class BrandValidator:AbstractValidator<BrandViewsModels>
    {
        public BrandValidator(SharedViewLocalizer<BrandValidatorResource> localizer ,IBrandService  brandService)
        {

            RuleFor(x => x.BrandName).Must((reg, c) => !brandService.IsExistedName(reg.Id, reg.BrandName))
                .WithMessage(localizer.GetLocalizedString("msg_NameBrandAlreadyExists"));
            RuleFor(x => x.BrandName).NotNull().WithMessage(localizer.GetLocalizedString("msg_NotEmpty"));  



        }
    }
}