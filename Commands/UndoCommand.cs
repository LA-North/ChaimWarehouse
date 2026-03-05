using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command that undoes the last command that supports undo.
    /// Works with the command history stored by the invoker.
    /// </summary>
    public class UndoCommand : ICommand
    {
        public void Execute(string[] args)
        {
            
        }
    }
}
