using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models.Dto
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        public double unitprice { get; set; }

    }
}
