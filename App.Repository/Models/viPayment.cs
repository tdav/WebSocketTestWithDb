namespace App.Repository.Models;

public class viPayment
{
    public int Id { get; set; }
    public int Amount { get; set; }

    public int? PaymentTypeId { get; set; }
    public string PaymentType { get; set; }

    public int? OrderId { get; set; }
    public int PaymentStatusId { get; set; }
    public string PaymentStatus { get; set; }

    public string Phone { get; set; }
    public string DriverInfo { get; set; }
    public Guid CreateUser { get; set; }
    public DateTime CreateDate { get; set; }
}
