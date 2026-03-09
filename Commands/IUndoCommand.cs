using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Interface for commands that support execution and undo.
    /// Used by commands that modify the warehouse state.
    /// </summary>
    public interface IUndoCommand : ICommand
    {
        void Undo();
    }
}
