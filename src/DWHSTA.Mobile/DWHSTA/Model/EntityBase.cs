using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWHSTA.Model
{
    /// <summary>
    /// Represents a entity base
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Initialze an instance of an entity base on <see cref="EntityBase"/>
        /// </summary>
        public EntityBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Identifies the entity
        /// </summary>
        public string Id { get; set; }

        ///// <summary>
        ///// Stores the creation moment
        ///// </summary>
        //public DateTimeOffset CreatedAt { get; set; }

        ///// <summary>
        ///// Stores the last update moment
        ///// </summary>
        //public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Concurrency token
        /// </summary>
        public string Version { get; set; }
    }
}
