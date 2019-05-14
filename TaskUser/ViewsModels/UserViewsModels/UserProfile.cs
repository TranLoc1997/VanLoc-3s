using AutoMapper;
using TaskUser.Models;

namespace TaskUser.ViewsModels.UserViewsModels
{
    public class UserProfile :Profile
    {
        public UserProfile (){
            CreateMap<User, UserViewsModels>();
            CreateMap<User, LoginViewModel>();
            CreateMap<User, EditViewPassword>();
            CreateMap<User, EditViewEmail>();
        }
        
    }
}