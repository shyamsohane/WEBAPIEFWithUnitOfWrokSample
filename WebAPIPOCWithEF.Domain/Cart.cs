using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebAPIPOCWithEF.Domain
{
    public class Cart : BaseEntity
    {
        public long CustomerId { get; set; }

        [StringLength(10)]
        public string CartName { get; set; }

        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
