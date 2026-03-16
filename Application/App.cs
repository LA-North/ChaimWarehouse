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
    public static class App
    {
        /// <summary>
        /// Run the main application loop.
        /// </summary>
        public static void Run()
        {
            InputStringProvider inputStringProvider = new InputStringProvider();
            CommandInvoker commandInvoker = new CommandInvoker();
            ShowWelcome();

            while (true)
            {
                string input = inputStringProvider.GetNextCommandString().ToLower();
                string inputToComper = input.Split(" ")[0];
                string[] args = input.Split(" ").Skip(1).ToArray();

                switch (inputToComper)
                {
                    case "additem":
                        commandInvoker.Execute(new AddNewItemCommand(), args);
                        break;
                    case "addstock":
                        commandInvoker.Execute(new AddStockCommand(), args);
                        break;
                    case "removestock":
                        commandInvoker.Execute(new RemoveStockCommand(), args);
                        break;
                    case "undo":
                        commandInvoker.Execute(new UndoCommand(commandInvoker), args);
                        break;
                    case "link":
                        commandInvoker.Execute(new LinkToFileCommand(inputStringProvider), args);
                        break;
                    case "list":
                        commandInvoker.Execute(new ListWarehouseCommand(), args);
                        break;
                    case "query":
                        commandInvoker.Execute(new QueryCommand(), args);
                        break;
                    case "help":
                        commandInvoker.Execute(new HelpCommand(), args);
                        break;
                    case "exit":
                        commandInvoker.Execute(new ExitCommand(), args);
                        Log.Information("Exiting application.");
                        return;
                    default:
                        Log.Warning("Unknown command: {Input}", input);
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the welcome message and basic instructions to the user
        /// when the application starts.
        /// </summary>
        private static void ShowWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("     WAREHOUSE MANAGEMENT SYSTEM      ");
            Console.WriteLine("======================================");
            Console.WriteLine("Type HELP to see available commands.");
            Console.WriteLine("Type EXIT to close the application.");
            Console.ResetColor();
        }
    }
}
