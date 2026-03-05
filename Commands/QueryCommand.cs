using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.QueryFolder;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command that runs a query on the warehouse items.
    /// Allows filtering, selecting fields and sorting the results.
    /// </summary>
    public class QueryCommand : ICommand
    {
        public void Execute(string[] args)
        {
            
        }
    }
}
