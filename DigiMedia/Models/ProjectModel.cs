namespace DigiMedia.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }

    }
}
