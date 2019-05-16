using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskUser.Filters;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.StockViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class StockController : Controller
    {
        // GET
       private readonly IStockService _stockService;
        private readonly IStoreService _storeService;
        private readonly IProductSerive _productSerive;
        public StockController(IStockService stockService,
            IStoreService storeService,
            IProductSerive productSerive)
        {
            _stockService = stockService;
            _storeService = storeService;
            _productSerive = productSerive;
            
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var listStock = await _stockService.GetStockListAsync();
            return View(listStock);

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            ViewBag.ProductID = new SelectList(_productSerive.GetProduct(), "Id", "ProductName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StockViewModels stock)
        {
            if (ModelState.IsValid)
            {
                
                var addStock = await _stockService.Create(stock);
                if (addStock != null)
                {
                    TempData["AddSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index", addStock);
                }
            }
            TempData["AddFailure"] = "err_Failure";
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), 
                "Id", "StoreName",stock.StoreId);
            ViewBag.ProductID = new SelectList(_productSerive.GetProduct(), 
                "Id", "StoreName",stock.ProductId);
            return View();
        }


        [HttpGet]
        public  async Task<IActionResult> Edit(int  productId,int?storeId)
        {
            if (productId==0 && storeId==0)
            {
                return BadRequest();
            }
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            ViewBag.ProductID = new SelectList(_productSerive.GetProduct(), "Id", "ProductName");
            var getStock = await _stockService.GetIdStock(productId,storeId);
           
            return View(getStock);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int productId,int storeId,StockViewModels editStock)
        {
           
            if (ModelState.IsValid)
            {
                
                    if (productId == editStock.ProductId && storeId==editStock.StoreId)
                    {
                        
                        await _stockService.EditStock(productId,storeId,editStock);
                        TempData["EditSuccessfuly"] = "msg_Successfuly";
                        return RedirectToAction("Index");
                    }
                
                    return BadRequest();
               
            }
            
            TempData["EditFailure"] = "err_Failure";
            ViewBag.StoreId = new SelectList(_storeService.GetStore(), "Id", "StoreName");
            ViewBag.ProductID = new SelectList(_productSerive.GetProduct(), "Id", "ProductName");
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? productId,int? storeId)
        {
            if (productId !=null && storeId !=null )
            {
                _stockService.Delete(productId.Value,storeId.Value);
                TempData["DeleteSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
                
            }
            TempData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
           
        }
        
    }
}