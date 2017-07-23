using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWHSTA.Resources;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents an active table order
    /// </summary>
    public class TableOrder : EntityBase
    {
        /// <summary>
        /// Table number
        /// </summary>
        public int Table { get; set; }

        /// <summary>
        /// Pax number
        /// </summary>
        public int Pax { get; set; }

        /// <summary>
        /// Worker mainly assigned to the table
        /// </summary>
        public string Worker { get; set; }

        public string TableNumberStr
        {
            get
            {
                return string.Format("{0}: {1}", Literals.Table, Table);
            }
        }
        public string PaxStr
        {
            get
            {
                return string.Format("{0}: {1}", Literals.PAX, Pax);
            }
        }

        /// <summary>
        /// Table status regarding current order
        /// </summary>
        //public TableStatus Status { get; set; }
    }
}
