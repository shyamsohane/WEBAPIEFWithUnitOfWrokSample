using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIPOCWithEF.Domain
{
    public class Order : BaseEntity
    {
        public decimal TotalOrderAmount { get; set; }
        public long CustomerId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public enum OrderStatus
    {
        Submitted,
        Cancelled,
        Delivered
    }
}
