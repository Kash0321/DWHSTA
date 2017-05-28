using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// One of the categories hierarchy item
    /// </summary>
    public class MenuItemCategory : EntityBase
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
        /// Category to which the category belongs
        /// </summary>
        public MenuItemCategory ParentCategory { get; set; }

        /// <summary>
        /// Image or shot of the category
        /// </summary>
        public string Image { get; set; }
    }
}
