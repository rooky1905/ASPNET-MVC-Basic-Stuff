using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC.Models
{
    public class Category
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Cannot be less than zero.")]
        public int DisplayOrder { get; set; }
    }
}