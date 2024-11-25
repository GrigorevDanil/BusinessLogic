using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable(nameof(Shop) + "s");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title)
                .HasMaxLength(Shop.MAX_TITLE_LENGHT)
                .IsRequired();

        }
    }
}
