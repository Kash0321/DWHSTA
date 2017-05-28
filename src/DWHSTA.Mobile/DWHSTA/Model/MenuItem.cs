using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents a menu item
    /// </summary>
    public class MenuItem : EntityBase
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Short description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Customer cost
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Category to which the item belongs
        /// </summary>
        public MenuItemCategory Category { get; set; }

        /// <summary>
        /// Image or shot of the item
        /// </summary>
        public string Image { get; set; }
    }
}
