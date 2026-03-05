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

        public Func<IEnumerable<Item>, object> Execute(string selectString);
        

    }
}
