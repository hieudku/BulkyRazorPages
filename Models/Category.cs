using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyRazorPages.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage ="Please enter between 1 and 100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
