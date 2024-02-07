namespace App.Repository.Models;

public class viCreateOrder
{
    public int PayMethod { get; set; }
    public int Kilowatt { get; set; }

    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}

public class viCreateOrderBilling
{
    public int ProductId { get; set; }
    public int PricePerProduct { get; set; }
    public int Quantity { get; set; }

    public string Phone { get; set; }

    public int KassaId { get; set; }
    public Guid UserId { get; set; }
    public string UserInfo { get; set; }
}

public class viCreateOrderBillingResponse
{
    public int OrderId { get; set; }
    public string PayUrl { get; set; }
}

public class viOrderPaid
{
    public int OrderId { get; set; }
    public Guid UserId { get; set; }
    public int Amount { get; set; }
}
