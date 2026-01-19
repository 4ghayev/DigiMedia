using DigiMedia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiMedia.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<ProjectModel>
    {
        public void Configure(EntityTypeBuilder<ProjectModel> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x=>x.Category).IsRequired();

            builder.HasOne(x => x.Category).WithMany(c => c.Projects).HasForeignKey(x => x.CategoryId).HasPrincipalKey(x=>x.Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
