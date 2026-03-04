using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    internal interface IUndoCommand
    {
        void Execute(string[] args);
        void Undo();
    }
}
