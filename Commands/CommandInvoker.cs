using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Invoker that executes commands and keeps history
    /// so they can be undone later.
    /// </summary>
    public class CommandInvoker
    {
        public void Execute(ICommand command, string[] args)
        {
            command.Execute(args);
        }

        public void Execute(IUndoCommand undoCommand, string[] args)
        {

        }

        public void Undo()
        {

        }
    }
}
