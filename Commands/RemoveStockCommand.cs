using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    internal class RemoveStockCommand : IUndoCommand
    {
        public void Execute(string[] args)
        {
            
        }
        public void Undo()
        {
        }
    }
}
