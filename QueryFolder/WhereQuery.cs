using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.QueryFolder
{
    /// <summary>
    /// Handles the WHERE part of the query.
    /// Supports conditions on the item propertyes like [&& ||  < > == ...].
    /// </summary>
    public class WhereQuery : IQueryType
    {
        
        public Func<IEnumerable<Item>, object> Execute(string queryTypeString)
        {
            return null;
        }
        private bool EvaluateCondition(Item item, string condition)
        {
            return false;
        }
        private bool Compare(object itemValue, string rightSide, string op)
        {
            return false;
        }
        private bool CheckEnumProperty(Item item, string condition)
        {
            return false;
        }
        private PropertyInfo GetProperty(string propertyName)
        {
            return null;
        }
    }
}
