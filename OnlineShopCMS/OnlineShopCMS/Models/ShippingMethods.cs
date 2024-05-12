namespace OnlineShopCMS.Models
{
    public class ShippingMethods
    {
        public int ShippingMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ShippingMethods() { }


        
    }
}