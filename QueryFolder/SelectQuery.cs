using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.QueryFolder
{
    
    internal class SelectQuery : IQueryType
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
