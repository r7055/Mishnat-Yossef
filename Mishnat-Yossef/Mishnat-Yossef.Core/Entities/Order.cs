

 namespace Mishnat_Yossef.Core.Entities
{
    public class Order
    {
        public string OrderId { get; set; }
        public int Payment { get; set; }
        public int UserId { get; set; }
        public DateTime DateOrder { get; set; }
        public string  StationId { get; set; }
        public string SellingId { get; set; }
    }
}
