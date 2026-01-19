using DigiMedia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiMedia.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<ProjectModel>
    {
        public void Configure(EntityTypeBuilder<ProjectModel> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
        }
    }
}
