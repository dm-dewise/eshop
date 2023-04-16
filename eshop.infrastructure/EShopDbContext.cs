using eshop.infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace eshop.infrastructure
{
    public class EShopDbContext: DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    }
}
