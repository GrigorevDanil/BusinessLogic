using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable(nameof(Warehouse) + "s");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title)
                .HasMaxLength(Warehouse.MAX_TITLE_LENGHT)
                .IsRequired();

            builder.HasMany(e => e.ProductWarehouses)
                .WithOne()
                .HasForeignKey(e => e.WarehouseId);
        }
    }
}
