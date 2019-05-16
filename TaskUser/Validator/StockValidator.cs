using FluentValidation;
using Microsoft.Extensions.Localization;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.ViewsModels.StockViewsModels;

namespace TaskUser.Validator
{
   
        public class StockValidator:AbstractValidator<StockViewModels>
        {
       
            public  StockValidator(IStockService stockService, IStringLocalizer<StockValidatorResource> localizer)
            {
                RuleFor(x => x.Quantity).GreaterThanOrEqualTo(1).WithMessage(localizer["quantity greater than of equal to"]);;
                RuleFor(x => x.Quantity).NotNull().WithMessage(localizer["not empty"]);
                RuleFor(x => x.ProductId).NotNull().WithMessage(localizer["not empty"]);
                RuleFor(x => x.StoreId).NotNull().WithMessage(localizer["not empty"]);
            }
        }
 
}