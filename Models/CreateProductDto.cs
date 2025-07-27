using System.ComponentModel.DataAnnotations;

namespace PostgreEcommerceWebApi.Models
{
    public class CreateProductDto
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
