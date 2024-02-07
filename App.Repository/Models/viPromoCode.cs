namespace App.Repository.Models
{
    public class viPromoCode
    {
        public string Code { get; set; }
        public string Comment { get; set; }
        public int Value { get; set; }
        public int PromoCodeTypeId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
