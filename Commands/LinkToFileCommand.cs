using ChaimWarehouse.InputTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Commands
{
    /// <summary>
    /// Command that loads and runs commands from a file.
    /// Allows executing multiple commands automatically from a text file.
    /// </summary>
    public class LinkToFileCommand : ICommand
    {
        private InputStringProvider Provider { get; set; }

        public LinkToFileCommand(InputStringProvider provider)
        {
            Provider = provider;
        }

        public void Execute(string[] args)
        {
        }
    }
}
