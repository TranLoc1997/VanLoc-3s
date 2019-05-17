using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.Service;
using TaskUser.ViewsModels.StockViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class StockController : Controller
    {
        // GET
       private readonly IStockService _stockService;
        private readonly IStoreService _storeService;
        private readonly IProductService _productService;
        private readonly SharedViewLocalizer<CommonResource> _localizer;
        private readonly SharedViewLocalizer<StockResource> _stockLocalizer;
        public StockController(IStockService stockService,
            IStoreService storeService,
            IProductService productService,
            SharedViewLocalizer<CommonResource> localizer,
            SharedViewLocalizer<StockResource> stockLocalizer
           )
        {
            _stockService = stockService;
            _storeService = storeService;
            _productService = productService;
            _localizer = localizer;
            _stockLocalizer = stockLocalizer;

        }
        // GET
        /// <summary>
        /// show index tock
        /// </summary>
        /// <returns>index of stock</returns>
        public async Task<IActionResult> Index()
        {
            var listStock = await _stockService.GetStockListAsync();
            return View(listStock);

        }
        /// <summary>
        /// get create stock
        /// </summary>
        /// <returns>view create of stock</returns>
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            ViewBag.ProductID = new SelectList(_productService.GetProduct(), "Id", "ProductName");
            return View();
        }
        /// <summary>
        /// post create of stock
        /// </summary>
        /// <param name="stock"></param>
        /// <returns>view index of stock else view</returns>
        [HttpPost]
        public async Task<IActionResult> Create(StockViewModels stock)
        {
            if (ModelState.IsValid)
            {
                
                var addStock = await _stockService.Create(stock);
                if (addStock != null)
                {
                    TempData["AddSuccessfuly"] = _localizer.GetLocalizedString("msg_AddSuccessfuly").ToString();
                    return RedirectToAction("Index", addStock);
                }
            }
            ViewData["AddFailure"] = _stockLocalizer.GetLocalizedString("err_AddFailure");
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), 
                "Id", "StoreName",stock.StoreId);
            ViewBag.ProductID = new SelectList(_productService.GetProduct(), 
                "Id", "StoreName",stock.ProductId);
            return View();
        }
        /// <summary>
        /// get edit stock
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="storeId"></param>
        /// <returns>return edit of stock</returns>

        [HttpGet]
        public  async Task<IActionResult> Edit(int?  productId,int?storeId)
        {
            if (productId==null && storeId==null)
            {
                return BadRequest();
            }
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            ViewBag.ProductID = new SelectList(_productService.GetProduct(), "Id", "ProductName");
            var getStock = await _stockService.GetIdStock(productId,storeId);
           
            return View(getStock);
        }
        /// <summary>
        /// get edit stock
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="storeId"></param>
        /// <param name="editStock"></param>
        /// <returns>view index of edir</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(int productId,int storeId,StockViewModels editStock)
        {
           
            if (ModelState.IsValid)
            {
                
                    if (productId == editStock.ProductId && storeId==editStock.StoreId)
                    {
                        
                        await _stockService.EditStock(productId,storeId,editStock);
                        TempData["EditSuccessfuly"] = _localizer.GetLocalizedString("msg_EditSuccessfuly").ToString();
                        return RedirectToAction("Index");
                    }
                
                    return BadRequest();
               
            }
            
            ViewData["EditFailure"] = _stockLocalizer.GetLocalizedString("err_EditFailure");
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            ViewBag.ProductID = new SelectList(_productService.GetProduct(), "Id", "ProductName");
            return View();
        }
        /// <summary>
/// delete of sstock
/// </summary>
/// <param name="productId"></param>
/// <param name="storeId"></param>
/// <returns>index</returns>
        [HttpGet]
        public IActionResult Delete(int? productId,int? storeId)
        {
            if (productId !=null && storeId !=null )
            {
                _stockService.Delete(productId.Value,storeId.Value);
                TempData["DeleteSuccessfuly"] = _localizer.GetLocalizedString("msg_DeleteSuccessfuly").ToString();
                return RedirectToAction("Index");
                
            }
            ViewData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
           
        }
        
    }
}