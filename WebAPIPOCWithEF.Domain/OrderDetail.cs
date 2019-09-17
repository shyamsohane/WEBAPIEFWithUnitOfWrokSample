using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIPOCWithEF.Domain
{
    public class OrderDetail : BaseEntity
    {
        public long ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public long OrderID { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
