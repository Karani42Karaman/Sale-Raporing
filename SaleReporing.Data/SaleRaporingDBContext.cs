using Microsoft.EntityFrameworkCore;
using SaleRaporing.Core.Model;
using SaleReporing.Data.Configuration;
 

namespace SaleReporing.Data
{
    public class SaleRaporingDBContext :DbContext
    {
        public DbSet<SaleRaporingModel> SaleRaporingModel { get; set; }

        public SaleRaporingDBContext(DbContextOptions<SaleRaporingDBContext> contextOptions):base(contextOptions)
        {

        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new SaleRaporingConfiguration());
            base.OnModelCreating(modelBuilder);
        }








    }
}
