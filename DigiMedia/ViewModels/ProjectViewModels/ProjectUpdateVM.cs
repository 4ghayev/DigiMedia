using System.ComponentModel.DataAnnotations;

namespace DigiMedia.ViewModels.ProjectViewModels
{
    public class ProjectUpdateVM
    {
        public int Id { get; set; }
        [Required,MaxLength(128),MinLength(3)] 
        public string Name { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        

        public int CategoryId { get; set; }
    }
}
