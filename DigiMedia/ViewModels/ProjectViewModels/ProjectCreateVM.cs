using System.ComponentModel.DataAnnotations;

namespace DigiMedia.ViewModels.ProjectViewModels
{
    public class ProjectCreateVM
    {

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public int CategoryId { get; set; }
    }
}
