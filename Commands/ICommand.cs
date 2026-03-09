using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Interface for commands that can only run but cannot be undone.
    /// </summary>
    public interface ICommand
    {
        void Execute(string[] args);
    }
}
