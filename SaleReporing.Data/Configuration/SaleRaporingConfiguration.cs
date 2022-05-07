using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaleRaporing.Core.Model;
 

namespace SaleReporing.Data.Configuration
{
    public class SaleRaporingConfiguration : IEntityTypeConfiguration<SaleRaporingModel>
    {
        public void Configure(EntityTypeBuilder<SaleRaporingModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
        

            builder
                .Property(m => m.Customer)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Product)
                .IsRequired()
                .HasMaxLength(50);


            builder
                .Property(m => m.DateOfSale)
                .IsRequired();

            builder
                .Property(m => m.TotalPrice)
                .IsRequired();


            builder
                .Property(m => m.TotalProductSold)
                .IsRequired();

        }
    }
}
