using AutoMapper;
using TaskUser.Models;
using TaskUser.Models.Sales;

namespace TaskUser.ViewsModels.UserViewsModels
{
    public class UserProfile :Profile
    {
        public UserProfile (){
            CreateMap<User, UserViewsModels>();
            CreateMap<User, LoginViewModel>();
            CreateMap<User, EditViewPassword>();
            CreateMap<User, EditUserViewsModels>();
           
        }
        
    }
}