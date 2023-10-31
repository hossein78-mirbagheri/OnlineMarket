using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public byte[] Image { get; set; } // برای ذخیره تصاویر
        public bool IsActive { get; set; } // برای مزایده
        public Users Seller { get; set; }
    }
}