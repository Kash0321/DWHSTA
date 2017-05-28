using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents a business worker 
    /// </summary>
    public class Worker : EntityBase
    {
        /// <summary>
        /// Roles that worker assumes
        /// </summary>
        public int[] Roles { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the workers is working at this moment
        /// </summary>
        public bool IsWorkingNow { get; set; }
    }
}
