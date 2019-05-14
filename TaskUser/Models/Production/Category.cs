using System.Collections.Generic;

namespace TaskUser.Models.Production
{
    public class Category
    {
        public Category()
        {
            
        }
        public Category(int id, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
            
            
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        
//        public virtual ICollection<Product>Products { get; set; }
        
    }
}