using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product) + "s");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(Product.MAX_TITLE_LENGHT);

            builder.Property(p => p.Cost)
                .IsRequired();

            builder.HasMany(p => p.ProductResources)
                .WithOne(p => p.Product)
                .HasForeignKey(pr => pr.ProductId);

            builder.HasMany(e => e.ProductWarehouses)
                .WithOne()
                .HasForeignKey(e => e.ProductId);
        }
    }
}
