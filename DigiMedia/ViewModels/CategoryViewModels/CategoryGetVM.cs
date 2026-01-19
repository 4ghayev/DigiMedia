using System.ComponentModel.DataAnnotations;

namespace DigiMedia.ViewModels.CategoryViewModels
{
    public class CategoryGetVM
    {
        public int Id { get; set; }
        [Required, MaxLength(128), MinLength(3)]
        public string Name { get; set; } = string.Empty;

    }
}
