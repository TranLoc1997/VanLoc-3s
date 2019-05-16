using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.BrandViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class BrandController : Controller
    {
      
        private readonly IBrandService _brandService;
        private readonly SharedViewLocalizer<BrandResource> _brandLocalizer;
        public BrandController(IBrandService  brandService,SharedViewLocalizer<BrandResource> brandLocalizer)
        {
            _brandService = brandService;
            _brandLocalizer = brandLocalizer;

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
                    TempData["AddSuccessfuly"] = _brandLocalizer.GetLocalizedString("msg_AddSuccessfuly").ToString();
                    return RedirectToAction("Index", addBrand);
                }
            }
            ViewData["AddFailure"] = "err_Failure";
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
                    TempData["EditSuccessfuly"] = _brandLocalizer.GetLocalizedString("msg_Successfuly").ToString();
                    return RedirectToAction("Index");
                    
                }              
            }
            ViewData["EditFailure"] = "err_Failure";
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
                TempData["DeleteSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
            }
            ViewData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }

        

    }
}