using Sales.Models.Enuns;

namespace Sales.Models;

public class SalesRecord
{
    public SalesRecord()
    {
    }

    public SalesRecord(int id, decimal amount, DateTime date, SaleStatus status, Seller? seller)
    {
        Id = id;
        Amount = amount;
        Date = date;
        Status = status;
        Seller = seller;
    }

    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public SaleStatus Status { get; set; }
    public Seller? Seller { get; set; }
}