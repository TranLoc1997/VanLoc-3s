using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Production;
using TaskUser.ViewsModels.CategoryViewsModels;

namespace TaskUser.Serivice
{
    public interface ICategoryService
    {
        Task<List<CategoryViewsModels>> GetCategoryListAsync();
        Task<CategoryViewsModels> Create(CategoryViewsModels addCategory);
        IEnumerable<Category> Categories{ get;}
        Task<CategoryViewsModels> GetIdCategory(int? id);
        Task<CategoryViewsModels> EditCategory(int?id, CategoryViewsModels editCategory);
        void Delete(int id);
    }

    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       
        public async Task<List<CategoryViewsModels>> GetCategoryListAsync()//
        {
            var list = await _context.Categories.ToListAsync();
            var listCategory = _mapper.Map<List<CategoryViewsModels>>(list);
            return listCategory;
        }
        public async Task<CategoryViewsModels> Create(CategoryViewsModels addCategory)
        {            
            var category = new Category()
            {
                CategoryName = addCategory.CategoryName,
                
                    
            };
            
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return addCategory;
        }
        public IEnumerable<Category> Categories => _context.Categories;
        public async Task<CategoryViewsModels> GetIdCategory(int? id)
        {
            var findCategory=await _context.Categories.FindAsync(id);
            var categoryDtos = _mapper.Map<CategoryViewsModels>(findCategory);
            return categoryDtos;
        }
        public async Task<CategoryViewsModels> EditCategory(int?id, CategoryViewsModels editCategory)
        {
            try
            {
                var category =_context.Categories.Find(id);
            
                category.CategoryName = editCategory.CategoryName;
            
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return editCategory;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            

        }
        public void Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null) 
                return;
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
        
    }
}