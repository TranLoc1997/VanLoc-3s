namespace TaskUser.Models.Production
{
    public class Product
    {
//        public Product()
//        {
//            
//        }
//        public Product(int id, string productName, string picture,int brandId, int categoryId, int modelYear, decimal listPrice)
//        {
//            Id = id;
//            ProductName = productName;
//            Picture = picture;
//            BrandId = brandId;
//            CategoryId = categoryId;
//            ModelYear = modelYear;
//            ListPrice = listPrice;
//            
//            
//        }
        public int Id { get; set; }
        public string ProductName { get; set; }
//        [DisplayFormat(DataFormatString = "{0:0,0}")]
        
        public string Picture { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int  ModelYear { get; set; }
        public decimal ListPrice { get; set; }
        
       public virtual Category Categorie { get; set; }
        
       public virtual Stock Stock { get; set; }
        
//        public virtual ICollection<Stock>Stocks { get; set; }
        public virtual Brand Brand { get; set; }
        
    }
}


