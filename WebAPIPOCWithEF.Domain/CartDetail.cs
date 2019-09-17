using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIPOCWithEF.Domain
{
    public class CartDetail : BaseEntity
    {
        public long ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public long CartId { get; set; }
        public virtual Product Product { get; set; }
    }
}
