using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command that decreases the quantity of an item in the warehouse.
    /// </summary>
    public class RemoveStockCommand : IUndoCommand
    {
        public void Execute(string[] args)
        {
            
        }

        public void Undo()
        {
        }
    }
}
