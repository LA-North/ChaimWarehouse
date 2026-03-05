using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.QueryFolder
{
    /// <summary>
    /// Handles the ORDER BY part of the query.
    /// Parses property name and direction (ascending / descending)
    /// and returns a function that sorts the items.
    /// </summary>
    public class OrderbyQuery : IQueryType
    {
        public Func<IEnumerable<Item>, object> Execute(string orderbyString)
        {
            return null;

        }
        private PropertyInfo GetProperty(string propertyName)
        {
            return null;
        }
    }
}
