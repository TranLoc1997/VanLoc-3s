using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskUser.Encryption;
using TaskUser.Models;
using TaskUser.ViewsModels;
using TaskUser.ViewsModels.UserViewsModels;


namespace TaskUser.Serivice
{
    public interface IUserService
    {
        bool Login(string email, string password);
        Task<List<UserViewsModels>> GetUserListAsync();
        Task<UserViewsModels> Create(UserViewsModels user);
        Task<EditViewPassword> GetPassword(int? id);
        IEnumerable<User> GetUser();
        Task<UserViewsModels> GetId(int? id);
        Task<UserViewsModels> EditAsync(UserViewsModels userParam);
        User GetName(string name);
        void Delete(int id);
        Task<bool> UserPassword(EditViewPassword passUser);
        bool IsExistedEmailUser(int id, string email);

    }

    public class UserService : IUserService
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserService(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
       /// <summary>
       /// ckeck login
       /// </summary>
       /// <param name="email"></param>
       /// <param name="password"></param>
       /// <returns>true of flase</returns>
        public bool Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            var user = _context.Users.FirstOrDefault(x =>
                x.Email == email && SecurePasswordHasher.Verify(password, x.PassWord));

            if (user == null)

            {
                return false;
            }

            return true;
        }
//get list show user
        public async Task<List<UserViewsModels>> GetUserListAsync()//
        {
            var list = await _context.Users.ToListAsync();
            var listUser = _mapper.Map<List<UserViewsModels>>(list);
            return listUser;
            
        }

        public IEnumerable<User> GetUser()
        {
            return _context.Users;
        } 
//create user
        public async Task<UserViewsModels> Create(UserViewsModels user)
        {
               
            var users = new User()
            {
                Name = user.Name,
                Email = user.Email,
                PassWord =SecurePasswordHasher.Hash(user.PassWord),
                Phone = user.Phone,
                StoreId = user.StoreId,
                IsActiver = user.IsActiver
                    
            };
            
            await _context.Users.AddAsync(users);
            await _context.SaveChangesAsync();
            return user;
        }
        
  //get edit id      
        public async Task<UserViewsModels> GetId(int? id)
        {
            var findUser=await _context.Users.FindAsync(id);
            var userDtos = _mapper.Map<UserViewsModels>(findUser);
           
            return userDtos;
          
          
        }

     //post edit id   

        public async Task<UserViewsModels> EditAsync(UserViewsModels userParam)
        {
            try
            {
                var user = await _context.Users.FindAsync(userParam.Id);
                
                user.Name = userParam.Name;
               user.Email = userParam.Email;
                user.Phone = userParam.Phone;
                user.IsActiver = userParam.IsActiver;
                user.StoreId = userParam.StoreId;
                
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return userParam;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            

        }
        //get password
        public async Task<EditViewPassword> GetPassword(int? id)
        {
            var findPassWord= await _context.Users.FindAsync(id);
            var usereditDtos = _mapper.Map<EditViewPassword>(findPassWord);           
            return usereditDtos;
        }
        
        //post user Password
        public async Task<bool> UserPassword(EditViewPassword passUser)
        {
            try
            {
                var user = await _context.Users.FindAsync(passUser);
                user.PassWord = SecurePasswordHasher.Hash(passUser.NewPassword);
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }
       
        // delete user
        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) 
                return;
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        //ckeck name
        public User GetName(string email)
        {
            var user = _context.Users.FirstOrDefault(x =>
                x.Email == email );

            return user;
        }
        //ckeck trung email
        public bool IsExistedEmailUser(int id,string email)
        {
            return _context.Users.Any(x => x.Email == email && x.Id != id);
        }
    }
}