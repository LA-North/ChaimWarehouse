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
    /// Reads the name, price and optional properties from the command arguments.
    /// </summary>
    public class AddNewItemCommand : IUndoCommand
    {
        public void Execute(string[] args)
        {

        }
        public void Undo()
        {
        }
    }
}
