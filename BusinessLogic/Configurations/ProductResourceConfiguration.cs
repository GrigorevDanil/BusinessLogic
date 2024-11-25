using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class ProductResourceConfiguration : IEntityTypeConfiguration<ProductResource>
    {
        public void Configure(EntityTypeBuilder<ProductResource> builder)
        {
            builder.ToTable(nameof(ProductResource) + "s");

            builder.HasKey(pr => new { pr.ProductId, pr.ResourceId });

            builder.Property(pr => pr.Quantity)
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithMany(p => p.ProductResources)
                .HasForeignKey(e => e.ProductId);

            builder.HasOne(e => e.Resource)
                .WithMany(p => p.ProductResources)
                .HasForeignKey(e => e.ResourceId);
        }
    }
}
