﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Models;
using TaskUser.Models.Sales;
using TaskUser.ViewsModels.StoreViewsModels;

namespace TaskUser.Service
{
    public interface IStoreService
    {
        Task<List<StoreViewModels>> GetStoreListAsync();
        IEnumerable<Store> GetStore();
        Task<StoreViewModels> Create(StoreViewModels addStore);
        Task<StoreViewModels> GetIdStore(int? id); //
        Task<StoreViewModels> EditStore(int? id, StoreViewModels editStore);
        bool IsExistedEmailStore(int id, string email);
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
       // get show store
        public async Task<List<StoreViewModels>> GetStoreListAsync()//
        {
            var list = await _context.Stores.ToListAsync();
            var listStore = _mapper.Map<List<StoreViewModels>>(list);
            return listStore;
        }

        public IEnumerable<Store> GetStore()
        {
            return _context.Stores;
        } 
        // get create store
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
        //get edit id store
        public async Task<StoreViewModels> GetIdStore(int? id)
        {
            var findStore=await _context.Stores.FindAsync(id);
            var storeDtos = _mapper.Map<StoreViewModels>(findStore);
            return storeDtos;
        }
        // get edit store
        public async Task<StoreViewModels> EditStore(int?id, StoreViewModels editStore)
        {
            try
            {
                var store =await _context.Stores.FindAsync(id);
            
                store.StoreName = editStore.StoreName;
                store.Email = editStore.Email;
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
        // ckeck email
        public bool IsExistedEmailStore(int id,string email)
        {
            return _context.Stores.Any(x => x.Email == email && x.Id != id);
        }
        
        //delete store
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