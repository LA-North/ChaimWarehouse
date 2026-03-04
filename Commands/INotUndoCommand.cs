using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    internal interface INotUndoCommand
    {
        void Execute(string[] args);
    }
}
