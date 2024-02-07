namespace App.Repository.Models;

public class viTransactionCurrent
{
    public int Id { get; set; }
    public string ChargePointName { get; set; } = null!;
    public int ConnectorId { get; set; }
}
