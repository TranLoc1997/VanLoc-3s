using FluentValidation;
using Microsoft.Extensions.Localization;
using TaskUser.ViewsModels.StockViewsModels;

namespace TaskUser.Validator.StockValidator
{
   
        public class StockValidator:AbstractValidator<StockViewModels>
        {
       
            public  StockValidator(IStringLocalizer<StockViewModels> localizer)
            {
                RuleFor(x => x.Quantity).NotNull().WithMessage(localizer["not empty"]);
                RuleFor(x => x.ProductId).NotNull().WithMessage(localizer["not empty"]);
                RuleFor(x => x.StoreId).NotNull().WithMessage(localizer["not empty"]);
            }
        }
 
}