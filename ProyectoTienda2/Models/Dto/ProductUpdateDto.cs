using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models.Dto
{
    public class ProductUpdateDto
    {
        [Required]
        public int productId { get; set; }
        [Required]
        [MaxLength(30)]
        public string? productName { get; set; }
        public double unitprice { get; set; }
    }
}
