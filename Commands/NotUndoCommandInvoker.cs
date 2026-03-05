using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Invoker used for commands that don't support undo.
    /// Simply runs the command without storing it in history.
    /// </summary>
    public class NotUndoCommandInvoker
    {
        public void Execute(ICommand notUndoCommand, string[] args) 
        {
           
        }
    }
}
