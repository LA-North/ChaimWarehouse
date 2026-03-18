using CommandLine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command that adds a new item to the warehouse.
    /// </summary>
    public class AddNewItemCommand : IUndoCommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("ADDING.");
        }

        public void Undo()
        {
        }
    }
}
