using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class DistanceConfiguration : IEntityTypeConfiguration<Distance>
    {
        public void Configure(EntityTypeBuilder<Distance> builder)
        {
            builder.ToTable(nameof(Distance) + "s");

            builder.HasKey(d => new { d.ShopId, d.WarehouseId });

            builder.HasOne(e => e.Shop)
                .WithMany(e => e.Distances)
                .HasForeignKey(e => e.ShopId);

            builder.HasOne(e => e.Warehouse)
                .WithMany(e => e.Distances)
                .HasForeignKey(e => e.WarehouseId);

            builder.Property(e => e.Length)
                .IsRequired();
        }
    }
}
