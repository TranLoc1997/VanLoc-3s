using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Production;
using TaskUser.ViewsModels.BrandViewsModels;
using TaskUser.ViewsModels.CategorieViewsModels;

namespace TaskUser.Serivce
{
   
    public interface IBrandService
    {
        Task<List<BrandViewsModels>> GetBranListAsync();
        Task<BrandViewsModels> Create(BrandViewsModels addBrand);
        IEnumerable<Brand> Brands{ get;}
        Task<BrandViewsModels> GetIdbrand(int? id);
        Task<BrandViewsModels> EditBrand(int?id, BrandViewsModels editBrand);
        void Delete(int id);
//        IEnumerable<Brand> GetBrands();
    }
//
    public class BrandService : IBrandService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BrandService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

//        public IEnumerable<Brand> GetBrands()
//        {
//            return _context.Brands;
//        }
        public IEnumerable<Brand> Brands => _context.Brands;

        
//       AddBrandViewsModels
        public async Task<List<BrandViewsModels>> GetBranListAsync()//
        {
            var list = await _context.Brands.ToListAsync();
            var listBrand = _mapper.Map<List<BrandViewsModels>>(list);
            return listBrand;
        }
        
        public async Task<BrandViewsModels> Create(BrandViewsModels addBrand)
        {            
            var brand = new Brand()
            {
                BrandName = addBrand.BrandName
                
                    
            };
            
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return addBrand;
        }
        public async Task<BrandViewsModels>  GetIdbrand(int? id)
        {
            var findBrand= await _context.Brands.FindAsync(id);
            var brandDtos = _mapper.Map<BrandViewsModels>(findBrand);
            return brandDtos;
        }
        public async Task<BrandViewsModels> EditBrand(int?id, BrandViewsModels editBrand)
        {
            try
            {
                var brand =_context.Brands.Find(id);
            
                brand.BrandName = editBrand.BrandName;
            
                _context.Brands.Update(brand);
                await _context.SaveChangesAsync();
                return editBrand;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

           

        }
        public void Delete(int id)
        {
            var brand = _context.Brands.Find(id);
            if (brand == null) 
                return;
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }
//        
    }
}