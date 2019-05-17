using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Models;
using TaskUser.Service;
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
     /// <summary>
     /// get page index login
     /// </summary>
     /// <returns>view login</returns>
        [HttpGet]
        public IActionResult IndexLogin()
        {
            return View();
            
        }

        /// <summary>
        /// login
        /// </summary>
        /// <param name="model"></param>
        /// <returns>view index controller user</returns>
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
        /// <summary>
        /// Language
        /// </summary>
        /// <param name="culture"></param>
        /// <param name="returnUrl"></param>
        /// <returns>localredirect</returns>
        [HttpGet]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}