using Sales.Models.Enuns;

namespace Sales.Models;

public class SalesRecord
{
    public SalesRecord()
    {
    }

    public SalesRecord(int id, DateTime date, decimal amount, SaleStatus status, Seller? seller)
    {
        Id = id;
        Date = date;
        Amount = amount;
        Status = status;
        Seller = seller;
    }

    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public SaleStatus Status { get; set; }
    public Seller? Seller { get; set; }
}