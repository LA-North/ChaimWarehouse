using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command that prints all items currently stored in the warehouse.
    /// Useful for quickly viewing the full inventory.
    /// </summary>
    public class ListWarehouseCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("List");
        }
    }
}
