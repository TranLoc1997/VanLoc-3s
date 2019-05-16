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
        /// <summary>
        /// show category    
        /// </summary>
        /// <returns>index category</returns>
        public async Task<IActionResult> Index()
        {
            var listCateogry = await _category.GetCategoryListAsync();
            return View(listCateogry);

        }
        /// <summary>
        /// get create category    
        /// </summary>
        /// <returns>view create category </returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// post create category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>view create category</returns>
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
        /// <summary>
        /// get edit category
        /// </summary>
        /// <param name="id"></param>
        /// <returns>view edit category</returns>
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
        /// <summary>
/// post edit category
/// </summary>
/// <param name="id"></param>
/// <param name="editCategory"></param>
/// <returns>return index category</returns>
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
        /// <summary>
        /// function Delete category 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>index category</returns>
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