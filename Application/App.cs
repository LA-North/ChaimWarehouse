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
