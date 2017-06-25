using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWSHTA.WebApi.DataObjects
{
    public class TableOrder : EntityData
    {
        /// <summary>
        /// Pax number
        /// </summary>
        public int Pax { get; set; }

        /// <summary>
        /// Worker mainly assigned to the table
        /// </summary>
        public string Worker { get; set; }

        /// <summary>
        /// Table status regarding current order
        /// </summary>
        public TableStatus Status { get; set; }
    }
}