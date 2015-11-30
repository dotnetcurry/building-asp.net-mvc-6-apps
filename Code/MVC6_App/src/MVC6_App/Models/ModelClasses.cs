using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC6_App.Models
{
    public class Category
    {
        [Key]
        public int CategoryId{ get; set; }
        [Required(ErrorMessage ="The Category Name is Must")]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "The Product Name is Must")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "The Price is Must")]
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
