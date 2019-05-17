using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.Service;
using TaskUser.ViewsModels.BrandViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly SharedViewLocalizer<CommonResource> _localizer;
        private readonly SharedViewLocalizer<BrandResource> _brandLocalizer;
        public BrandController(IBrandService  brandService,SharedViewLocalizer<CommonResource> localizer,SharedViewLocalizer<BrandResource> brandLocalizer)
        {
            _brandService = brandService;
            _brandLocalizer = brandLocalizer;
            _localizer = localizer;

        }
        // GET
        /// <summary>
        /// show index brand
        /// </summary>
        /// <returns>viewbrand</returns>
        public async Task<IActionResult> Index()
        {
            var listBrand = await _brandService.GetBranListAsync();
            return View(listBrand);


        }
        /// <summary>
        /// get create brand
        /// </summary>
        /// <returns>views create Brand</returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// post create brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns>view index brand</returns>
        [HttpPost]
        public async Task<IActionResult> Create(BrandViewsModels brand)
        {
            if (ModelState.IsValid)
            {
                var addBrand = await _brandService.Create(brand);
                if (addBrand != null)
                {
                    TempData["AddSuccessfuly"] = _localizer.GetLocalizedString("msg_AddSuccessfuly").ToString();
                    return RedirectToAction("Index", addBrand);
                }
            }
            ViewData["AddFailure"] = _brandLocalizer.GetLocalizedString("err_AddFailure");
            return View();
        }
        /// <summary>
        /// get edit brand
        /// </summary>
        /// <param name="id"></param>
        /// <returns>view edit </returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var getBrand = await _brandService.GetIdbrand(id.Value);
           
            return View(getBrand);
        }
        /// <summary>
        /// post edit brand
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editBrand"></param>
        /// <returns>index brand</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,BrandViewsModels editBrand)
        {
           
            if (ModelState.IsValid)
            {
                if (id == editBrand.Id)
                {
                    
                    await _brandService.EditBrand(id,editBrand);
                    TempData["EditSuccessfuly"] = _localizer.GetLocalizedString("msg_EditSuccessfuly").ToString();
                    return RedirectToAction("Index");
                    
                }              
            }
            ViewData["EditFailure"] = _brandLocalizer.GetLocalizedString("err_EditFailure");
            return View();
        }
        /// <summary>
        /// get delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns>index brand</returns>
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id!=null)
            {
                _brandService.Delete(id.Value);
                TempData["DeleteSuccessfuly"] = _localizer.GetLocalizedString("msg_DeleteSuccessfuly").ToString();
                return RedirectToAction("Index");
            }
            TempData["DeleteFailure"] = _localizer.GetLocalizedString("err_Failure");
            return RedirectToAction("Index");
            
        }
    }
}