﻿

namespace BoraIlkProje2.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int Quantity { get; set; }
        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}
