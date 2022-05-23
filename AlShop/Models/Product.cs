using System.ComponentModel.DataAnnotations;

namespace AlShop.Models
{
    public class Product : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsStock { get; set; }
        public int CategoryId { get; set; }


        //Navigation Property
        public Category Category { get; set; }
    }
}
