using Microsoft.EntityFrameworkCore;
using PizzaASPNet.Model;

namespace PizzaASPNet.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection");
        }
    }
}