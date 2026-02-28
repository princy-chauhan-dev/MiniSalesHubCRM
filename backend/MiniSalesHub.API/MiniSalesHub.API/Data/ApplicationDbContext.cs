using Microsoft.EntityFrameworkCore;
using MiniSalesHubCRM.Models;

namespace MiniSalesHubCRM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}