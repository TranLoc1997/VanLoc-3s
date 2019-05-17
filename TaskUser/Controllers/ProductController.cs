using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.Service;
using TaskUser.ViewsModels.ProductViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly SharedViewLocalizer<CommonResource> _localizer;
        private readonly SharedViewLocalizer<ProductResource> _productLocalizer;
        public ProductController(IProductService productService,
            IBrandService brandService,
            ICategoryService categoryService,
            SharedViewLocalizer<CommonResource> localizer,
            SharedViewLocalizer<ProductResource> productLocalizer)
        {
            
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _localizer = localizer;
            _productLocalizer = productLocalizer;

        }
        // GET
        /// <summary>
        /// show index product    
        /// </summary>
        /// <returns>view index of product</returns>
        public async Task<IActionResult> Index()
        {
            var listStore = await _productService.GetProductListAsync();
            return View(listStore);
        }
        /// <summary>
        /// get create of product
        /// </summary>
        /// <returns>view create of product</returns>
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), "Id", "BrandName");  
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), "Id", "CategoryName");  
            return View();
        }
        /// <summary>
        /// post create of product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>return view index of product</returns>
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewsModels product)
        {
            if (ModelState.IsValid)
            {
                var addProduct = await _productService.Create(product);
                if (addProduct != null)
                { 
                    TempData["AddSuccessfuly"] = _localizer.GetLocalizedString("msg_AddSuccessfuly").ToString();
                    return RedirectToAction("Index");
                }
            }

            ViewData["AddFailure"] = _productLocalizer.GetLocalizedString("err_AddFailure");
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), 
                "Id", "CategoryName",product.CategoryId);  
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), 
                "Id", "BrandName",product.BrandId);
            return View();
        }
        /// <summary>
/// get edit product
/// </summary>
/// <param name="id"></param>
/// <returns>view edit of product</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), "Id", "BrandName");  
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), "Id", "CategoryName");  
            var getProduct = await _productService.GetIdProduct(id.Value);
                   
            return View(getProduct);
        }
        /// <summary>
        /// post edit product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editProduct"></param>
        /// <returns>view index of product</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,ProductViewsModels editProduct)
        {
           
            if (ModelState.IsValid)
            {
              
                if (id == editProduct.Id)
                {
                        
                    await _productService.EditProduct(id,editProduct);
                    TempData["EditSuccessfuly"] = _localizer.GetLocalizedString("msg_EditSuccessfuly").ToString();
                    return RedirectToAction("Index");
                }
                ViewData["EditFailure"] = _productLocalizer.GetLocalizedString("err_EditFailure");
                ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), 
                    "Id", "CategoryName",editProduct.CategoryId);  
                ViewBag.BrandId = new SelectList(_brandService.Getbrand(), 
                    "Id", "BrandName",editProduct.BrandId);
                
                return BadRequest();
                
            }
            ViewData["EditFailure"] = _productLocalizer.GetLocalizedString("err_EditFailure");
            ViewBag.CategoryId = new SelectList(_categoryService.GetCategory(), 
                "Id", "CategoryName",editProduct.CategoryId);  
            ViewBag.BrandId = new SelectList(_brandService.Getbrand(), 
                "Id", "BrandName",editProduct.BrandId);
            return View();
        }
        /// <summary>
        /// get delete of product
        /// </summary>
        /// <param name="id"></param>
        /// <returns>delete of product</returns>
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id!=null)
            {
                _productService.Delete(id.Value);
                TempData["DeleteSuccessfuly"] = _localizer.GetLocalizedString("msg_DeleteSuccessfuly").ToString();
                return RedirectToAction("Index");
            }
            ViewData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }
    }
}