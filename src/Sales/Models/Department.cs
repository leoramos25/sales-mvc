using System.ComponentModel.DataAnnotations;

namespace Sales.Models;

public class Department
{
  public Department()
  {
  }

  public Department(int id, string? name)
  {
    Id = id;
    Name = name;
  }

  public int Id { get; set; }
  public string? Name { get; set; }
  public ICollection<Seller> Sellers { get; private set; } = new List<Seller>();

  public void AddSeller(Seller seller)
  {
    Sellers.Add(seller);
  }

  public void RemoveSeller(Seller seller)
  {
    Sellers.Remove(seller);
  }

  public decimal TotalSales(DateTime initial, DateTime final)
  {
    return Sellers.Sum(seller => seller.TotalSales(initial, final));
  }
}