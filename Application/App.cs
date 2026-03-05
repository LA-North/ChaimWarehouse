using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.Commands;
using ChaimWarehouse.InputTypes;

namespace ChaimWarehouse.Application
{
    /// <summary>
    /// The main application controller.
    /// The App class is responsible for running the main command loop of the
    /// Warehouse Management System.
    /// </summary>
    public class App
    {
        /// <summary>
        /// Starts the main application loop.
        /// The method reads user commands from the input provider,
        /// parses the command name and arguments, and executes the command using the invoker.
        /// The loop runs until the user enters the "exit" command.
        /// </summary>
        public void Run()
        {
        }

        /// <summary>
        /// Displays the welcome message and basic instructions to the user
        /// when the application starts.
        /// </summary>
        public void ShowWelcome()
        {
            
        }
    }
}
