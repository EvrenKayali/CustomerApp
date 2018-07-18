namespace CustomerApp.DAL
{
    using CustomerApp.DAL.Mappings;
    using CustomerApp.Models;
    using Microsoft.EntityFrameworkCore;

    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        public CustomerContext()
        {

        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}