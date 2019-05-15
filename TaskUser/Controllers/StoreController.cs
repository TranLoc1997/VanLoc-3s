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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StoreViewModels store)
        {
            if (ModelState.IsValid)
            {
                var addStore = await _storeService.Create(store);
                if (addStore != null)
                {
                    TempData["create"] = "Add Store Success";
                    return RedirectToAction("Index", addStore);
                }
            }
            ViewBag.ErrorAdd = "Add Failure";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            var getstore =await _storeService.GetIdStore(id);
           
          return View(getstore);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,StoreViewModels editStore)
        {
           
            if (ModelState.IsValid)
            {
                    if (id == editStore.Id)
                    {
                        TempData["edit"] = "Edit Store Success";
                        await _storeService.EditStore(id,editStore);
                        return RedirectToAction("Index");
                    }
                    ViewBag.ErrorEdit = "Edit Failure";
                    return View();
            }
            ViewBag.ErrorEdit = "Edit Failure";
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _storeService.Delete(id);
            
            return RedirectToAction("Index");
        }
    }
}