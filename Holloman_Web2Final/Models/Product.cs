namespace Holloman_Web2Final.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string? Brand { get; set; }

        //Join reference
        public ICollection<Order> Orders { get; set; }
    }
}
