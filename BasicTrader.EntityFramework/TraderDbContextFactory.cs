using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Trader.EntityFramework
{
    public class TraderDbContextFactory : IDesignTimeDbContextFactory<TraderDbContext>
    {
        public TraderDbContext CreateDbContext(string[]? args = null)
        {
            var options = new DbContextOptionsBuilder<TraderDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=master;Trusted_Connection=True;", b => b.MigrationsAssembly("Trader.EntityFramework"));

            return new TraderDbContext(options.Options);
        }
    }
}
