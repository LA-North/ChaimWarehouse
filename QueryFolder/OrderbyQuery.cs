using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.QueryFolder
{
    
    internal class OrderbyQuery : IQueryType
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
