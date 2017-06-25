using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWSHTA.WebApi.DataObjects
{
    public enum ItemStatus
    {
        Ordered = 0,
        Prepared = 1,
        Served = 2,
        Cancelled = 10 
    }
}