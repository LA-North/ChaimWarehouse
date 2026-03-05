using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
   
    /// <summary>
    /// Interface for commands that can only run but cannot be undone.
    /// Used for actions like help, listing items or queries.
    /// </summary>
    public interface INotUndoCommand
    {
        void Execute(string[] args);
    }
}
