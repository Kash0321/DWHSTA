using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWSHTA.WebApi.DataObjects
{
    public class MenuItem : EntityData
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
        /// Image or shot of the item
        /// </summary>
        public string Image { get; set; }
    }
}