using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using TaskUser.Filters;
using TaskUser.Models;
using TaskUser.ViewsModels;
using TaskUser.Serivice;
using TaskUser.ViewsModels.UserViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStoreService _storeService;
        public UserController(
            DataContext context,
            IUserService userService,
            IStringLocalizer<UserController> localizer,
            IStoreService storeService)
        {
          
            _userService = userService;
            _storeService = storeService;
           
            
        }
     
//        [HttpGet]
//        public IActionResult IndexLogin()
//        {
//            return View();
//            
//        }
//
//      
//        [HttpPost]
//        public IActionResult IndexLogin(LoginViewModel model)
//        {
//            
//            
//            if (ModelState.IsValid)
//            
//            {
//                var user = _userService.Login(model.Email, model.PassWord);
//                
//                if (user)
//                {
//                    var name = _userService.GetName(model.Email);
//                    
//                    HttpContext.Session.SetString("name",name.Name);
//                    return RedirectToAction("Index", "User");
//                }
//            }
//            return View();
//
//            //----------------------------------------
//
//
//        }
        
//        [HttpGet]
//        public IActionResult Logout()
//        {
//
//            HttpContext.Session.Remove("name"); 
//            return RedirectToAction("IndexLogin");
//
//        }
        
        [HttpGet]
        public IActionResult Back()
        {

            return RedirectToAction("Index");

        }
        
        public async Task<IActionResult> Index()
        {
            var listUser = await _userService.GetUserListAsync();
            if (listUser==null)
            {
                return NotFound();

            }
            return View(listUser);

        }
        //ngon ngu
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
        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserViewsModels user)
        {
            if (ModelState.IsValid)
            {
                var adduser = await _userService.Create(user);
                if (adduser != null)
                {
                    
                    TempData["create"] = "Add Users Success";
                    return RedirectToAction("Index", adduser);
                }
            }
            ViewBag.ErrorAdd = "Add Failure";
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), 
                "Id", "StoreName",user.StoreId);
            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var findUser = await _userService.GetId(id);
            if (findUser ==null)
            {
                return BadRequest();
            }
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            return View(findUser);
        }

        


        [HttpPost]
        public async Task<IActionResult> Edit(UserViewsModels userParam)
        {
            if (ModelState.IsValid)
            {
                TempData["edit"] = "Edit Users Success";
                await _userService.EditAsync(userParam);
                return RedirectToAction("Index");
            }
            ViewBag.ErrorEdit = "Edit Failure";
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName",userParam.StoreId);
            return View(userParam);
        }
        
        [HttpGet]        
        
        public async Task<IActionResult> EditPassword(int id)
        {
            var findPassword = await _userService.GetPassword(id);
            if (findPassword == null)
            {
                return NotFound();
            }

            return PartialView("_ChangePassword",findPassword);
        }
   
        [HttpPost]
        public async Task<IActionResult> EditPassword(EditViewPassword passwordUser)
        { 
            if (ModelState.IsValid)
            {
                var users =  await _userService.UserPassword(passwordUser);
                if (users)
                {
                    ViewData["Password"] = "Edit Password Success";
                }        
                ViewBag.ErrorEdit = "Edit Failure";
                return PartialView("_ChangePassword",passwordUser);       
            }
            ViewBag.ErrorEdit = "Edit Failure";
            return PartialView("_ChangePassword",passwordUser);
        }

        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            
            return RedirectToAction("Index");
        }


        
    }
    
}