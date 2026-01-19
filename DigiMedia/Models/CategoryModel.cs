namespace DigiMedia.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ProjectModel>? Projects { get; set; }
    }
}
