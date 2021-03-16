using System.ComponentModel.DataAnnotations;

namespace ASPNET_MVC.Models
{
    public class Applications
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    

}