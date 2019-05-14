using FluentValidation;
using Microsoft.Extensions.Localization;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.CategoryViewsModels;

namespace TaskUser.Validator.CategoryValidator
{
    public class CategoryValidator:AbstractValidator<CategoryViewsModels>
    {
        
        public CategoryValidator(SharedViewLocalizer localizer ,ICategoryService  categoryService)
        {
            var category = categoryService.Categories;
            foreach (var categorie in category)
            {

                RuleFor(x => x.CategoryName).NotEqual(categorie.CategoryName)
                    .WithMessage(localizer.GetLocalizedString("vld_notequal"));
            }
            RuleFor(x=>x.CategoryName).NotNull().WithMessage(localizer.GetLocalizedString("not empty"));
        }
        
    }
}