using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Models;
using TaskUser.Serivice;
using TaskUser.ViewsModels;

namespace TaskUser.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController
        (
            DataContext context,
            IUserService userService
            )
        
        {
          
            _userService = userService;
            
           
            
        }
     
        [HttpGet]
        public IActionResult IndexLogin()
        {
            return View();
            
        }

      
        [HttpPost]
        public IActionResult IndexLogin(LoginViewModel model)
        {
            
            
            if (ModelState.IsValid)
            
            {
                var user = _userService.Login(model.Email, model.PassWord);
                
                if (user)
                {
                    var name = _userService.GetName(model.Email);
                    
                    HttpContext.Session.SetString("name",name.Name);
                    return RedirectToAction("Index", "User");
                }
            }
            return View();

            //----------------------------------------


        }
        [ServiceFilter(typeof(ActionFilter))]
        [HttpGet]
        public IActionResult Logout()
        {

            HttpContext.Session.Remove("name"); 
            return RedirectToAction("IndexLogin");

        }
        
//        [HttpGet]
//        public IActionResult Back()
//        {
//
//            return RedirectToAction("Index",User);
//
//        }
    }
}