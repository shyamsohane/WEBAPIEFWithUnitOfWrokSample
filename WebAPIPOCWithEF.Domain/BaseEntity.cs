using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPIPOCWithEF.Domain
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public DateTime? DateAdded { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
