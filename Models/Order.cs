namespace BoraIlkProje2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Ouantity { get; set; }
        public int Price { get; set; }

        public int AppUserId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}

