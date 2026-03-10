using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Invoker used for commands that don't support undo.
    /// Simply runs the command without storing it in history.
    /// </summary>
    public class CommandInvoker
    {
        public void Execute(ICommand Command, string[] args) 
        {  }
    }
}
