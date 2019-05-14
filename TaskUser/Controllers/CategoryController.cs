using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Serivce;
using TaskUser.Serivice;
using TaskUser.ViewsModels.CategorieViewsModels;
using TaskUser.ViewsModels.CategoryViewsModels;

namespace TaskUser.Controllers
{
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
                    TempData["create"] = "Add Store Success";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.ErrorAdd = "Add Failure";
            return View(category);
        }

        [HttpGet]
        public async  Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var getCategory = await _category.GetIdCategory(id);
           
            return View(getCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int?id ,CategoryViewsModels editCategory)
        {
           
            if (ModelState.IsValid)
                if (id==editCategory.Id)
                { 
                    
                    await _category.EditCategory(id,editCategory);
                    TempData["edit"] = "Edit Category Success";
                    return RedirectToAction("Index");
                    
                }       
            ViewBag.ErrorEdit = "Edit Failure";
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _category.Delete(id);
            
            return RedirectToAction("Index");
        }
    }
}