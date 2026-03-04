using CommandLine;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Commands
{
    internal class AddNewItemCommand : IUndoCommand
    {
        public void Execute(string[] args)
        {

        }
        public void Undo()
        {
        }
    }
}
