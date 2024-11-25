using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class ProductWarehouseConfiguration : IEntityTypeConfiguration<ProductWarehouse>
    {
        public void Configure(EntityTypeBuilder<ProductWarehouse> builder)
        {
            builder.ToTable(nameof(ProductWarehouse) + "s");

            builder.HasKey(pr => new { pr.ProductId, pr.WarehouseId });

            builder.Property(pr => pr.Quantity)
                .IsRequired();

            builder.HasOne(e => e.Product)
               .WithMany(p => p.ProductWarehouses)
               .HasForeignKey(e => e.ProductId);

            builder.HasOne(e => e.Warehouse)
                .WithMany(p => p.ProductWarehouses)
                .HasForeignKey(e => e.WarehouseId);
        }
    }
}
