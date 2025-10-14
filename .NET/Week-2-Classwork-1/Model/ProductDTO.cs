using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Week_2_Classwork_1.Model
{
    public class ProductDTO
    {
        [ValidateNever]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please Enter the name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter the Product Category")]
        [StringLength(100)]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public int StockQuantity {  get; set; }
    }
}
