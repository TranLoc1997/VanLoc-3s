using TaskUser.Models.Production;
using TaskUser.Models.Sales;

namespace TaskUser.Models
{
    public class User 
    {
//        public User()
//        {
//            
//        }
//        public User(int id, string name, string email,string phone, string password, string city, int storeid, bool isactiver)
//        {
//            Id = id;
//            Name = name;
//            Email = email;
//            Phone = phone;
//            PassWord = password;
//            StoreId = storeid;
//            IsActiver = isactiver;
//            
//        }
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Phone { get; set; }
        public bool IsActiver { get; set;}
        public virtual Store Store { get; set; }
       
        
    }
}