using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using ChaimWarehouse.Commands;
using ChaimWarehouse.InputTypes;
using ChaimWarehouse.WarehouseFolder;

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
        /// Run the main application loop.
        /// </summary>
        public void Run()
        {
            var inputStringProvider = new InputStringProvider();
            var commandInvoker = new CommandInvoker();
            var appParser = new AppParser(inputStringProvider, commandInvoker);
            ShowWelcome();

            while (true)
            {
                // Takes the input separate the args from the command doing parse to the input and execute it.
                string input = inputStringProvider.GetNextCommandString().ToLower();
                string[] args = input.Split(" ").Skip(1).ToArray();
                var command = appParser.Parse(input);

                if (command is not null)
                {
                    if (command is ExitCommand)
                        break;

                    commandInvoker.Execute(command, args);
                }
                else
                {
                    Log.Warning("Unknown command: {Input}", input);
                }
            }
        }

        /// <summary>
        /// Displays the welcome message and basic instructions to the user
        /// when the application starts.
        /// </summary>
        private static void ShowWelcome()
        {
            Log.Information(
                "\n======================================\n" +
                "     WAREHOUSE MANAGEMENT SYSTEM      \n" +
                "======================================\n" +
                "Type HELP to see available commands.\n" +
                "Type EXIT to close the application."
                );
        }
    }
}
