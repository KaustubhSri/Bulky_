using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Category Order")]
        [Range(1,100,ErrorMessage ="Display order must be between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
} 
