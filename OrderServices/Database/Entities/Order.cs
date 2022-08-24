using System.ComponentModel.DataAnnotations.Schema;

namespace OrderServices.Database.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }
    }
}
