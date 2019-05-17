using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TaskUser.ViewsModels.ProductViewsModels
{
    public class ProductViewsModels
    {
        

//       
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int  ModelYear { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal ListPrice { get; set; }
        public string Picture { get; set; }
        public IFormFile  PictureFile { get; set; }
    }
}