using AutoMapper;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.BrandViewsModels
{
    public class BrandProfile:Profile
    { public  BrandProfile()
        {
            CreateMap<Brand, BrandViewsModels>();
         
        }
            
        }
       
}