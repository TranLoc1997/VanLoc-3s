using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskUser.Filters;
using TaskUser.Resources;
using TaskUser.Service;
using TaskUser.ViewsModels.CategoryViewsModels;

namespace TaskUser.Controllers
{
    [ServiceFilter(typeof(ActionFilter))]
    public class CategoryController : Controller
    {
        // GET
        private readonly ICategoryService _category;
        private readonly SharedViewLocalizer<CommonResource> _localizer;
        private readonly SharedViewLocalizer<CategoryResource> _categoryLocalizer;
        public CategoryController(ICategoryService category ,SharedViewLocalizer<CommonResource> localizer,SharedViewLocalizer<CategoryResource> categoryLocalizer)
        {
            _category = category;
            _localizer = localizer;
            _categoryLocalizer = categoryLocalizer;

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
                    TempData["AddSuccessfuly"] = _localizer.GetLocalizedString("msg_AddSuccessfuly");
                    return RedirectToAction("Index");
                }
            }
            ViewData["AddFailure"] = _categoryLocalizer.GetLocalizedString("err_AddFailure");
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
                    TempData["EditSuccessfuly"] = _localizer.GetLocalizedString("msg_EditSuccessfuly");
                    return RedirectToAction("Index");
                    
                }       
            ViewData["EditFailure"] = _categoryLocalizer.GetLocalizedString("err_EditFailure");
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
                TempData["DeleteSuccessfuly"] = _localizer.GetLocalizedString("msg_DeleteSuccessfuly");
                return RedirectToAction("Index");
            }
            ViewData["DeleteFailure"] = "err_Failure";
            return RedirectToAction("Index");
            
        }
    }
}