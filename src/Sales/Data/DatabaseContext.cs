using Microsoft.EntityFrameworkCore;

namespace Sales.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    DbSet<Sales.Models.Department>? Departments { get; set; }
}