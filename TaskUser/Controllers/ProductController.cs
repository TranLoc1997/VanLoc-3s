using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskUser.Filters;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.ProductViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class ProductController : Controller
    {
        private readonly IProductSerive _productSerive;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductSerive productService,
            IBrandService brandService,
            ICategoryService categoryService)
        {
            
            _productSerive = productService;
            _brandService = brandService;
            _categoryService = categoryService;

        }
        // GET
        public async Task<IActionResult> Index()
        {
            var listStore = await _productSerive.GetProductListAsync();
            return View(listStore);

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), "Id", "BrandName");  
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), "Id", "CategoryName");  
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewsModels product)
        {
            if (ModelState.IsValid)
            {
                var addProduct = await _productSerive.Create(product);
                if (addProduct != null)
                { 
                    TempData["AddSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index");
                }
            }
            TempData["AddFailure"] = "err_Failure";
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), 
                "Id", "CategoryName",product.CategoryId);  
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), 
                "Id", "BrandName",product.BrandId);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), "Id", "BrandName");  
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), "Id", "CategoryName");  
            var getProduct = await _productSerive.GetIdProduct(id.Value);
                   
            return View(getProduct);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,ProductViewsModels editProduct)
        {
           
            if (ModelState.IsValid)
            {
//                if (editProduct != null)
//                {
//                    return BadRequest();
//
//                }
               
                if (id == editProduct.Id)
                {
                        
                    await _productSerive.EditProduct(id,editProduct);
                    TempData["EditSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index");
                }
                TempData["EditFailure"] = "err_Failure";
                ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), 
                    "Id", "CategoryName",editProduct.CategoryId);  
                ViewBag.BrandId = new SelectList(_brandService.Getbrand(), 
                    "Id", "BrandName",editProduct.BrandId);
                
                return BadRequest();
                
            }
            TempData["EditFailure"] = "err_Failure";
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), 
                "Id", "CategoryName",editProduct.CategoryId);  
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), 
                "Id", "BrandName",editProduct.BrandId);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id!=null)
            {
                _productSerive.Delete(id.Value);
                TempData["DeleteSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
            }
            TempData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }
    }
}