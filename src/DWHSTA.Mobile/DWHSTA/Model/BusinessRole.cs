using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Indicates roles to assign to workers
    /// </summary>
    public enum BusinessRole
    {
        /// <summary>
        /// Attends tables and serves items
        /// </summary>
        Waiter = 0,

        /// <summary>
        /// Cooks food in the kitchen
        /// </summary>
        Cooker = 1,

        /// <summary>
        /// Prepares drinks
        /// </summary>
        Barman = 2,

        /// <summary>
        /// Welcomes and accommodate customers
        /// </summary>
        RoomManager = 3
    }
}
