using System.Collections.Generic;

namespace TaskUser.Models.Production
{
    public class Brand
    {
        public Brand()
        {
            
        }
        public Brand(int id, string brandName)
        {
            Id = id;
            BrandName = brandName;
            
            
        }
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual ICollection<Product>Product { get; set; }

    }
}
