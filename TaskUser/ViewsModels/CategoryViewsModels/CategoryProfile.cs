using AutoMapper;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.CategorieViewsModels
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryViewsModels.CategoryViewsModels>();
         
        }
        
        
    }
}