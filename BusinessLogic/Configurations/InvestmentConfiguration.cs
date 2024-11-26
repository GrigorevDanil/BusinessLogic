
using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Configurations
{
    public class InvestmentConfiguration : IEntityTypeConfiguration<Investment>
    {
        public void Configure(EntityTypeBuilder<Investment> builder)
        {
            builder.ToTable(nameof(Investment) + "s");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Profit)
                .IsRequired();

            builder.HasOne(e => e.Company)
                .WithMany(e => e.Investments)
                .HasForeignKey(e => e.CompanyId);
        }
    }
}
