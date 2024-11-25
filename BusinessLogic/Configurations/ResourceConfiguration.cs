using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable(nameof(Resource) + "s");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Title)
                .IsRequired()
                .HasMaxLength(Resource.MAX_TITLE_LENGHT);

            builder.Property(r => r.Unit)
                .IsRequired()
                .HasMaxLength(Resource.MAX_UNIT_LENGHT);


            builder.HasMany(r => r.ProductResources)
                .WithOne(r => r.Resource)
                .HasForeignKey(pr => pr.ResourceId);
        }
    }
}
