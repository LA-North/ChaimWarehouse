using CommandLine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command used to increase the stock of an existing item.
    /// </summary>
    public class AddStockCommand : IUndoCommand
    {
        public void Execute(string[] args) 
        {
            
            
        }
        public void Undo() 
        {
            
        }
    }
}
