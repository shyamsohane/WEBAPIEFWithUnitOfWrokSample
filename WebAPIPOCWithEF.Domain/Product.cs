using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPOCWithEF.Domain
{
    public class Product : BaseEntity
    {
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(100)]
        public string ImagePath { get; set; }

        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
