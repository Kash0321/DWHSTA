using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    public enum TableStatus
    {
        /// <summary>
        /// Customers are about to 
        /// </summary>
        New,
        RequiresAttention,
        WaitingItems,
        Payed
    }
}
