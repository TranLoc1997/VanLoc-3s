using AutoMapper;
using TaskUser.Models;
using TaskUser.Models.Sales;

namespace TaskUser.ViewsModels.StoreViewsModels
{
    public class StoreProfile :Profile
    {
        public StoreProfile (){
            
            CreateMap<Store, StoreViewModels>();
        }
        
    }
}