using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.QueryFolder
{
    /// <summary>
    /// Handles the SELECT part of the query.
    /// Supports selecting properties, or functions like SUM and AVG.
    /// </summary>
    public class SelectQuery : IQueryType
    {
        public Func<IEnumerable<Item>, object> Execute(string selectString)
        {
            return null;
        }
        private string ExtractProperty(string input, string keyword)
        {
            return null;
        }
        private PropertyInfo GetProperty(string propertyName)
        {
            return null;
        }
    }
}
