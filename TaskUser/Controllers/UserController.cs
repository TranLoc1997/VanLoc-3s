using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.ViewsModels;
using TaskUser.Service;
using TaskUser.ViewsModels.UserViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStoreService _storeService;
        private readonly SharedViewLocalizer<CommonResource> _localizer;
        private readonly SharedViewLocalizer<PasswordResource> _passwordLocalizer;
        private readonly SharedViewLocalizer<UserResource> _userLocalizer;
        public UserController(
          
            IUserService userService,
           
            IStoreService storeService,
            SharedViewLocalizer<CommonResource> localizer,
            SharedViewLocalizer<PasswordResource> passwordLocalizer,
            SharedViewLocalizer<UserResource> userLocalizer
            )
        {
          
            _userService = userService;
            _storeService = storeService;
            _localizer = localizer;
            _passwordLocalizer = passwordLocalizer;
            _userLocalizer = userLocalizer;

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
                    
                    TempData["AddSuccessfuly"] = _localizer.GetLocalizedString("msg_AddSuccessfuly").ToString();
                    return RedirectToAction("Index", addUser);
                }
            }
            ViewData["AddFailure"] =_userLocalizer.GetLocalizedString("err_AddFailure");
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
        public async Task<IActionResult> Edit(EditUserViewsModels userParam)
        {
            if (ModelState.IsValid)
            {
                await _userService.EditAsync(userParam);
                TempData["EditSuccessfuly"] = _localizer.GetLocalizedString("msg_EditSuccessfuly").ToString();
                return RedirectToAction("Index");
            }
            ViewData["EditFailure"] = _userLocalizer.GetLocalizedString("err_EditFailure");
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
                    TempData["EditPasswordSuccessfuly"] = _localizer.GetLocalizedString("msg_EditPasswordSuccessfuly").ToString();
                }        
                ViewData["EditPasswordFailure"] = "err_PasswordFailure";
                return PartialView("_ChangePassword",passwordUser);       
            }
            ViewData["EditPasswordFailure"] = "err_PasswordFailure";
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
                TempData["DeleteSuccessfuly"] = _localizer.GetLocalizedString("msg_DeleteSuccessfuly").ToString();
                return RedirectToAction("Index");
            }
            ViewData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }


        
    }
    
}