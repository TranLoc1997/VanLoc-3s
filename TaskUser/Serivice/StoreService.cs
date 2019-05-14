using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Sales;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Serivce
{
    public interface IStoreService
    {
        Task<List<StoreViewModels>> GetStoreListAsync();
        IEnumerable<Store> Stores{ get;}
        Task<StoreViewModels> Create(StoreViewModels addStore);
        Task<StoreViewModels> GetIdStore(int? id); //
        Task<EditstoreViewModels> EditStore(int?id, EditstoreViewModels editStore);
        void Delete(int id);



    }
    public class StoreService : IStoreService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public StoreService(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
//        
//
       
        public async Task<List<StoreViewModels>> GetStoreListAsync()//
        {
            var list = await _context.Stores.ToListAsync();
            var listStore = _mapper.Map<List<StoreViewModels>>(list);
            return listStore;
        }

        public IEnumerable<Store> Stores => _context.Stores;
        
        public async Task<StoreViewModels> Create(StoreViewModels addStore)
        {            
            var store = new Store()
            {
                StoreName = addStore.StoreName,
                Email = addStore.Email,
                Phone = addStore.Phone,
                City = addStore.City,
                State = addStore.State,
                Street = addStore.Street,
                ZipCode = addStore.ZipCode,
                    
            };
            
            await _context.Stores.AddAsync(store);
            await _context.SaveChangesAsync();
            return addStore;
        }          
        public async Task<StoreViewModels> GetIdStore(int? id)
        {
            var findStore=await _context.Stores.FindAsync(id);
            var storeDtos = _mapper.Map<StoreViewModels>(findStore);
            return storeDtos;
        }

        public async Task<EditstoreViewModels> EditStore(int?id, EditstoreViewModels editStore)
        {
            try
            {
                var store =await _context.Stores.FindAsync(id);
            
                store.StoreName = editStore.StoreName;
                store.Phone = editStore.Phone;
                store.City = editStore.City;
                store.State = editStore.State;
                store.Street = editStore.Street;
                store.ZipCode = editStore.ZipCode;
                _context.Stores.Update(store);
                await _context.SaveChangesAsync();
                return editStore;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            

        }
        public void Delete(int id)
        {
            var store = _context.Stores.Find(id);
            if (store == null) 
                return;
            _context.Stores.Remove(store);
            _context.SaveChanges();
        }

        
    }
}