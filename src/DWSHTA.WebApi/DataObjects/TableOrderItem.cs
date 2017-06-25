using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWSHTA.WebApi.DataObjects
{
    public class TableOrderItem : EntityData
    {
        public string TableOrder { get; set; }

        public string MenuItem { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public string Notes { get; set; }

        public ItemStatus Status { get; set; }
    }
}