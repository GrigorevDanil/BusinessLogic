using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable(nameof(Sale) + "s");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Value)
                .IsRequired();

			builder.Property(e => e.Date)
				.IsRequired();
		}
    }
}
