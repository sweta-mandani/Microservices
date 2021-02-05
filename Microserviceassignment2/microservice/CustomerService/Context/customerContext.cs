

using CustomerService.Entity;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CustomerService.Context
{
    public class customerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
