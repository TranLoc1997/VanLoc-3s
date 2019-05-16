using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Production;
using TaskUser.ViewsModels.ProductViewsModels;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Serivce
{
    public interface IProductSerive
    {
        Task<List<ProductViewsModels>> GetProductListAsync();

        Task<ProductViewsModels> Create(ProductViewsModels addProduct);

        IEnumerable<Product> GetProduct();
//        Task<AddStoreViewModels> Create(AddStoreViewModels addStore);
        Task<ProductViewsModels> GetIdProduct(int? id);
        Task<ProductViewsModels> EditProduct(int? id, ProductViewsModels editProduct);
        void Delete(int id);
    }

    public class ProductSerive : IProductSerive
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductSerive(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //show list product
        public async Task<List<ProductViewsModels>> GetProductListAsync()//
        {
            var list = await _context.Products.ToListAsync();
            var listProduct = _mapper.Map<List<ProductViewsModels>>(list);
            return listProduct;
        }
        
        public IEnumerable<Product>  GetProduct()
        {
            return _context.Products;
        }
        //create product 
        public async Task<ProductViewsModels> Create(ProductViewsModels addProduct)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", addProduct.PictureFile.FileName);
            using ( var stream = new FileStream(path,FileMode.Create))
            {
                await addProduct.PictureFile.CopyToAsync(stream);
                
            }
            var product = new Product()
            {
                ProductName = addProduct.ProductName,
                BrandId = addProduct.BrandId,
                CategoryId = addProduct.CategoryId,
                ModelYear = addProduct.ModelYear,
                ListPrice = addProduct.ListPrice,
                Picture = addProduct.PictureFile.FileName
            };  
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return addProduct;
            
            
        }
        //edit get product
        public async Task<ProductViewsModels> GetIdProduct(int? id)
        {
            var findProduct= await _context.Products.FindAsync(id);
            var productDtos = _mapper.Map<ProductViewsModels>(findProduct);;
            return productDtos;
        }
        // edit post product
        public async Task<ProductViewsModels> EditProduct(int? id, ProductViewsModels editProduct)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", editProduct.PictureFile.FileName);
                using ( var stream = new FileStream(path,FileMode.Create))
                {
                    await editProduct.PictureFile.CopyToAsync(stream);
                
                }
                var product =await _context.Products.FindAsync(id);
            
                product.BrandId = editProduct.BrandId;
                product.CategoryId = editProduct.CategoryId;
                product.ProductName = editProduct.ProductName;
                product.Picture = editProduct.PictureFile.FileName;
                product.ModelYear = editProduct.ModelYear;
                product.ListPrice = editProduct.ListPrice;
           
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return editProduct;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            

        }
        //delete product
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) 
                return;
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
        

      
    }
}