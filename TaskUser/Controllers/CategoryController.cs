using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.CategorieViewsModels;
using TaskUser.ViewsModels.CategoryViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class CategoryController : Controller
    {
        // GET
        private readonly ICategoryService _category;
        public CategoryController(ICategoryService category)
        {
            _category = category;
            
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var listCateogry = await _category.GetCategoryListAsync();
            return View(listCateogry);

        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewsModels category)
        {
            if (ModelState.IsValid)
            {
                
                var addCategory = await _category.Create(category);
                if (addCategory != null)
                {
                    TempData["AddSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index");
                }
            }
            TempData["AddFailure"] = "err_Failure";
            return View(category);
        }

        [HttpGet]
        public async  Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var getCategory = await _category.GetIdCategory(id.Value);
           
            return View(getCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id ,CategoryViewsModels editCategory)
        {
           
            if (ModelState.IsValid)
                if (id==editCategory.Id)
                { 
                    
                    await _category.EditCategory(id,editCategory);
                    TempData["EditSuccessfuly"] = "msg_Successfuly";
                    return RedirectToAction("Index");
                    
                }       
            TempData["EditFailure"] = "err_Failure";
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id!=null)
            {
                _category.Delete(id.Value);
                TempData["DeleteSuccessfuly"] = "msg_Successfuly";
                return RedirectToAction("Index");
            }
            TempData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }
    }
}