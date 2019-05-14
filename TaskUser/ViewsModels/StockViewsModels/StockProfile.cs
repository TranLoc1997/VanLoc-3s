using AutoMapper;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.StockViewsModels
{
    public class StockProfile:Profile
    {
        public StockProfile()
        {
            
            CreateMap<Stock, StockViewModels>();
        }
    }
}