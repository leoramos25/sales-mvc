using Microsoft.EntityFrameworkCore;
using Sales.Models;
using Sales.Models.Enuns;

namespace Sales.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Department>? Departments { get; set; }
    public DbSet<Seller>? Sellers { get; set; }
    public DbSet<SalesRecord>? SalesRecords { get; set; }
}