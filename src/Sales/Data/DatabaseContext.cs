using Microsoft.EntityFrameworkCore;

namespace Sales.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Sales.Models.Department>? Departments { get; set; }
}