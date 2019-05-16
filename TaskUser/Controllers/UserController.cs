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
     
         [HttpGet]
        public IActionResult Back()
        {

            return RedirectToAction("Index");

        }
        /// <summary>
        /// show index of user
        /// </summary>
        /// <returns>index of user</returns>
        public async Task<IActionResult> Index()
        {
            var listUser = await _userService.GetUserListAsync();
            if (listUser==null)
            {
                return NotFound();

            }
            return View(listUser);

        }
    /// <summary>
    /// get create of user
    /// </summary>
    /// <returns>view create of user</returns>
        
        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            return View();
        }
/// <summary>
/// post create of user
/// </summary>
/// <param name="user"></param>
/// <returns>index of User else view</returns>

        [HttpPost]
        public async Task<IActionResult> Create(UserViewsModels user)
        {
            if (ModelState.IsValid)
            {
                var addUser = await _userService.Create(user);
                if (addUser != null)
                {
                    
                    TempData["AddSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index", addUser);
                }
            }
            TempData["AddFailure"] = "err_Failure";
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), 
                "Id", "StoreName",user.StoreId);
            return View();
        }
        /// <summary>
        /// get edit of user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>create of user</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                
                return BadRequest();
            }
            var findUser = await _userService.GetId(id.Value);
            if (findUser ==null)
            {
                
                return BadRequest();
            }
            
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            return View(findUser);
        }

        
/// <summary>
/// post edit of user
/// </summary>
/// <param name="userParam"></param>
/// <returns>index of User else view</returns>

        [HttpPost]
        public async Task<IActionResult> Edit(UserViewsModels userParam)
        {
            if (ModelState.IsValid)
            {
                
                await _userService.EditAsync(userParam);
                TempData["EditSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
            }
            TempData["EditFailure"] = "err_Failure";
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName",userParam.StoreId);
            return View(userParam);
        }
        /// <summary>
        /// get edit password 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>view _change Password</returns>
        [HttpGet]        
        public async Task<IActionResult> EditPassword(int id)
        {
            var findPassword = await _userService.GetPassword(id);
            if (findPassword == null)
            {
                return BadRequest();
            }

            return PartialView("_ChangePassword",findPassword);
        }
   /// <summary>
   /// post edit password
   /// </summary>
   /// <param name="passwordUser"></param>
   /// <returns>index of User else view</returns>
        [HttpPost]
        public async Task<IActionResult> EditPassword(EditViewPassword passwordUser)
        { 
            if (ModelState.IsValid)
            {
                var users =  await _userService.UserPassword(passwordUser);
                if (users)
                {
                    TempData["EditSuccessfuly"] = "msg_Successfuly";
                }        
                TempData["EditFailure"] = "err_Failure";
                return PartialView("_ChangePassword",passwordUser);       
            }
            TempData["EditFailure"] = "err_Failure";
            return PartialView("_ChangePassword",passwordUser);
        }

        /// <summary>
        /// delete user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>view index of user</returns>
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id!=null)
            {
                _userService.Delete(id.Value);
                TempData["DeleteSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
            }
            TempData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }


        
    }
    
}