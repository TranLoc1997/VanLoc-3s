using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.ProductViewsModels;

namespace TaskUser.Controllers
{
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
            ViewBag.BrandId = new SelectList(_brandService.Brands, "Id", "BrandName");  
            ViewBag.CategoryId = new SelectList(_categoryService.Categories, "Id", "CategoryName");  
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
                   
                    TempData["create"] = "Add Product Success";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.ErrorAdd = "Add Failure";
            ViewBag.CategoryId = new SelectList(_categoryService.Categories, 
                "Id", "CategoryName",product.CategoryId);  
            ViewBag.BrandId = new SelectList(_brandService.Brands, 
                "Id", "BrandName",product.BrandId);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            ViewBag.BrandId = new SelectList(_brandService.Brands, "Id", "BrandName");  
            ViewBag.CategoryId = new SelectList(_categoryService.Categories, "Id", "CategoryName");  
            var getProduct = await _productSerive.GetIdProduct(id);
                   
            return View(getProduct);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int?id ,ProductViewsModels editProduct)
        {
           
            if (ModelState.IsValid)
            {
//                if (editProduct != null)
//                {
//                    
//                }
               
                if (id == editProduct.Id)
                {
                        
                    await _productSerive.EditProduct(id,editProduct);
                    TempData["edit"] = "Edit Product Success";
                    return RedirectToAction("Index");
                }
                ViewBag.CategoryId = new SelectList(_categoryService.Categories, 
                    "Id", "CategoryName",editProduct.CategoryId);  
                ViewBag.BrandId = new SelectList(_brandService.Brands, 
                    "Id", "BrandName",editProduct.BrandId);
                
                return BadRequest();
                
            }
            ViewBag.ErrorEdit = "Edit Failure";
            ViewBag.CategoryId = new SelectList(_categoryService.Categories, 
                "Id", "CategoryName",editProduct.CategoryId);  
            ViewBag.BrandId = new SelectList(_brandService.Brands, 
                "Id", "BrandName",editProduct.BrandId);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _productSerive.Delete(id);
            
            return RedirectToAction("Index");
        }
    }
}