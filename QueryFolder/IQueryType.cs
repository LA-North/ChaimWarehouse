using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.QueryFolder
{
    /// <summary>
    /// Interface for query operations (Select / Where / OrderBy).
    /// Each query type gets the raw query string and returns a function
    /// that runs on a collection of Items.
    /// </summary>
    public interface IQueryType
    {
        /// <summary>
        /// Parses the query string for this query type and builds the corresponding query operation.
        /// </summary>
        /// <param name="selectString">
        /// The raw query segment related to this query type.
        /// </param>
        /// <returns>
        /// A function that receives a collection of Items and executes
        /// the query operation on them, returning the result can be a collection or number.
        /// </returns>
        public Func<IEnumerable<Item>, object> Execute(string selectString);
    }
}
