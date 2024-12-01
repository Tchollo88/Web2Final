using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Holloman_Web2Final.Models
{
    
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
