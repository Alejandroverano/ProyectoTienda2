using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models.Dto
{
    public class ProductDto
    {
        public int productId { get; set; }
        [Required]
        public string? productName { get; set; }
        public double unitprice { get; set; }
    }
}
