using System.ComponentModel.DataAnnotations;

namespace AlShop.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
