using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Production;
using TaskUser.ViewsModels.CategorieViewsModels;
using TaskUser.ViewsModels.StockViewsModels;

namespace TaskUser.Serivce
{
   
    public interface IStockService
    {
        Task<List<StockViewModels>> GetStockListAsync();
        
        Task<StockViewModels> Create(StockViewModels addStock);

        IEnumerable<Stock> GetStock();
        
        Task<StockViewModels> GetIdStock(int? productId , int? storeId);

        Task<StockViewModels> EditStock(int? productId , int? storeId, StockViewModels editStock);

        void Delete(int? productId, int? storeId);

    }

    public class StockService : IStockService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public StockService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       
        public async Task<List<StockViewModels>> GetStockListAsync()
        {
            var list = await _context.Stocks.ToListAsync();
            var listStock = _mapper.Map<List<StockViewModels>>(list);
            return listStock;
        }

        public IEnumerable<Stock> GetStock()
        {
            return _context.Stocks;
        } 
        public async Task<StockViewModels> Create(StockViewModels addStock)
        {
            var ckeck =await _context.Stocks.FindAsync(addStock.ProductId, addStock.StoreId);
            if (ckeck!=null)
            {
                ckeck.Quantity += addStock.Quantity;
                _context.Stocks.Update(ckeck);
               await _context.SaveChangesAsync();
                return addStock;

            }
            else
            {
                var stock = new Stock()
                {
           
                    ProductId = addStock.ProductId,
                    StoreId = addStock.StoreId,
                    Quantity = addStock.Quantity
                
                    
                };

                _context.Stocks.Add(stock);
                await _context.SaveChangesAsync();
                return addStock;
                
            }

        }
        public async Task<StockViewModels> GetIdStock(int? productId , int? storeId)
        {
            var findStock = await _context.Stocks.FindAsync(productId,storeId);
           
            var stockDtos = _mapper.Map<StockViewModels>(findStock);
            return stockDtos;
        }

        public async Task<StockViewModels> EditStock(int? productId , int? storeId, StockViewModels editStock)
        {
            try
            {
                var ckeckEdit = await _context.Stocks.FindAsync(productId,storeId);
                ckeckEdit.Quantity = editStock.Quantity;
                _context.Stocks.Update(ckeckEdit);
                await _context.SaveChangesAsync();
                return editStock;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }
        public void Delete(int? productId , int? storeId)
        {
            var stock = _context.Stocks.FirstOrDefault(x=>x.ProductId == productId && x.StoreId == storeId);
            if (stock == null) 
                return;
            _context.Stocks.Remove(stock);
            _context.SaveChanges();
        }
       
    }
    
}