
using Productservice.Entity;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Productservice.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Location> Locations { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}