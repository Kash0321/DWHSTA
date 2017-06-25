using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents an active table order
    /// </summary>
    public class TableOrder : EntityBase
    {
        /// <summary>
        /// Pax number
        /// </summary>
        public int Pax { get; set; }

        /// <summary>
        /// Worker mainly assigned to the table
        /// </summary>
        public Worker Worker { get; set; }

        /// <summary>
        /// Items served or to serve
        /// </summary>
        public ICollection<MenuItem> Items { get; protected set; }

        /// <summary>
        /// Table status regarding current order
        /// </summary>
        public TableStatus Status { get; set; }
    }
}
