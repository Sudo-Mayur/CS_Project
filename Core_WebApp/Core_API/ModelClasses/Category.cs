using Core_API.ModelClasses;
using System.ComponentModel.DataAnnotations;
namespace Core_API.Models
{
    public class Category
    {
        [Key]
        public int CategoryRowId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
        [Required]
        [NonNegative(ErrorMessage = "Base price must be Positive value")]
        public int BasePrice { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
    public class Product
    {
        [Key]
        public int ProductRowId { get; set; }
        [Required]
        [StringLength(50)]
        public string? ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [Required]
        [StringLength(400)]
        public string? Description { get; set; }
        [Required]
        public int CategoryRowId { get; set; }
        [Required]
        [NonNegative(ErrorMessage ="Price Must be Positive Value")]
        public int Price { get; set; }

        public Category? Category { get; set; }
    }

    public class CategoryProduct
    {
        public int CategoryRowId { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }

       // public string? Description { get; set; }

        //public int Price { get; set; }
        public int BasePrice { get; set; }
        public List<Product>? Products { get; set; }

    }

    public class catpro
    {
        public Category category { get; set; }
        public List<Product>? Products { get; set; }
    }
        

    public class catANDprod
    {
        public int CategoryRowID { get; set; }
        public string? CategoryName { get; set; }
        public int BasePrice { get; set; }
        public int ProductRowID { get; set; }
        public string? ProductName { get; set; }
        public int? Price { get; set; }
    }
}





//dotnet ef migrations add SecurityMigration -c Core_API.ModelClasses.CodAuthDbContext
//dotnet ef database update -c Core_API.ModelClasses.CodAuthDbContext


//Modify the Product class by adding the Price int property in it, generate Migration, Update database