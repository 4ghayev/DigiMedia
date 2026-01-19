using System.ComponentModel.DataAnnotations;

namespace DigiMedia.ViewModels.ProjectViewModels
{
    public class ProjectGetVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required, MaxLength(128)]
        public string CategoryName { get; set; } = string.Empty;
    }
}
