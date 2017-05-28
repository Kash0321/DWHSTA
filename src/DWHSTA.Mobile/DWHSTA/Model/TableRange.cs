using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents a range of tables to assign to the waiters
    /// </summary>
    public class TableRange : EntityBase
    {
        /// <summary>
        /// Workers attending the range
        /// </summary>
        ICollection<Worker> AssignedWorkers { get; set; }

        /// <summary>
        /// Number of the lower position table in the range
        /// </summary>
        public int LowNumberTable { get; set; }

        /// <summary>
        /// Number of the higher position table in the range
        /// </summary>
        public int HighNumberTable { get; set; }
    }
}
