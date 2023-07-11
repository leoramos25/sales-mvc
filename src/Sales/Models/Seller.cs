using System.Linq;

namespace Sales.Models;

public class Seller
{
    public Seller()
    {
    }

    public Seller(int id, string? name, string? email, DateTime birthDate, decimal baseSalary, Department? department)
    {
        Id = id;
        Name = name;
        Email = email;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
        Department = department;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal BaseSalary { get; set; }
    public Department? Department { get; set; }
    public ICollection<SalesRecord> Sales { get; private set; } = new List<SalesRecord>();

    public void AddSales(SalesRecord salesRecord)
    {
        Sales.Add(salesRecord);
    }

    public void RemoveSales(SalesRecord salesRecord)
    {
        Sales.Remove(salesRecord);
    }

    public decimal TotalSales(DateTime initial, DateTime final)
    {
        return Sales
        .Where(salesRecord => salesRecord.Date >= initial && salesRecord.Date <= final)
        .Sum(salesRecord => salesRecord.Amount);
    }
}