using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Serivce;
using TaskUser.ViewsModels.BrandViewsModels;

namespace TaskUser.Controllers
{
    public class BrandController : Controller
    {
      
        private readonly IBrandService _brandService;
        public BrandController(IBrandService  brandService)
        {
            _brandService = brandService;
            
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var listBrand = await _brandService.GetBranListAsync();
            return View(listBrand);


        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BrandViewsModels brand)
        {
            if (ModelState.IsValid)
            {
                var addBrand = await _brandService.Create(brand);
                if (addBrand != null)
                {
                    TempData["create"] = "Add Brand Success";
                    return RedirectToAction("Index", addBrand);
                }
            }
            ViewBag.ErrorAdd = "Add Failure";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            var getBrand = await _brandService.GetIdbrand(id);
           
            return View(getBrand);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int?id ,BrandViewsModels editBrand)
        {
           
            if (ModelState.IsValid)
            {
                if (id == editBrand.Id)
                {
                    
                    await _brandService.EditBrand(id,editBrand);
                    TempData["edit"] = "Edit Brand Success";
                    return RedirectToAction("Index");
                    
                }              
            }
            ViewBag.ErrorEdit = "Edit Failure";
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _brandService.Delete(id);
            
            return RedirectToAction("Index");
        }

    }
}