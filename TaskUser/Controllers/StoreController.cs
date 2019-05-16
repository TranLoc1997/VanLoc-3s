using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Serivice;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            
            _storeService = storeService;
            
        }
        /// <summary>
        /// show index of store
        /// </summary>
        /// <returns>return view</returns>
        public async Task<IActionResult> Index()
        {
            var listStore = await _storeService.GetStoreListAsync();
            return View(listStore);

        }
        
        [HttpGet]
        public IActionResult Back()
        {

            return RedirectToAction("Index");

        }
        /// <summary>
/// get create of store
/// </summary>
/// <returns>view create of store</returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
/// post create of store
/// </summary>
/// <param name="store"></param>
/// <returns>index of store else view</returns>
        [HttpPost]
        public async Task<IActionResult> Create(StoreViewModels store)
        {
            if (ModelState.IsValid)
            {
                var addStore = await _storeService.Create(store);
                if (addStore != null)
                {
                    TempData["AddSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index", addStore);
                }
            }
            TempData["AddFailure"] = "err_Failure";
            return View();
        }
        /// <summary>
        /// get edit of store
        /// </summary>
        /// <param name="id"></param>
        /// <returns>view edit of stroe</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int?id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var getstore =await _storeService.GetIdStore(id.Value);
           
          return View(getstore);
        }
        /// <summary>
        /// post edit of store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editStore"></param>
        /// <returns>index of store else view</returns>

        [HttpPost]
        public async Task<IActionResult> Edit(int id ,StoreViewModels editStore)
        {
           
            if (ModelState.IsValid)
            {
                    if (id == editStore.Id)
                    {
                        
                        await _storeService.EditStore(id,editStore);
                        TempData["EditSuccessfuly"] = "msg_Successfuly";
                        return RedirectToAction("Index");
                    }
                TempData["EditFailure"] = "err_Failure";
                    return BadRequest();
            }
            TempData["EditFailure"] = "err_Failure";
            return View();
        }
        /// <summary>
        /// delete of store
        /// </summary>
        /// <param name="id"></param>
        /// <returns>index</returns>
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id!=null)
            {
                _storeService.Delete(id.Value);
                TempData["DeleteSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
            }
            TempData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }
    }
}