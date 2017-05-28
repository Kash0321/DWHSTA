using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents an active table
    /// </summary>
    public class Table : EntityBase
    {
        /// <summary>
        /// Pax number
        /// </summary>
        public int Pax { get; set; }

        /// <summary>
        /// Worker mainly assigned to the table
        /// </summary>
        public Worker Worker { get; set; }


    }
}
