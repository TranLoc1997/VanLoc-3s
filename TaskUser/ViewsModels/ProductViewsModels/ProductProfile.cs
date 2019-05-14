using AutoMapper;
using TaskUser.Models.Production;
using TaskUser.Models.Sales;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.ViewsModels.ProductViewsModels
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewsModels>();
            
        }
        
    }
}
