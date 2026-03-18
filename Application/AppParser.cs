using ChaimWarehouse.Commands;
using ChaimWarehouse.InputTypes;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.Application
{
    public class AppParser
    {
        public InputStringProvider InputStringProvider { get; set; }

        public CommandInvoker CommandInvoker { get; set; }

        public AppParser(InputStringProvider inputStringProvider, CommandInvoker commandInvoker)
        {
            InputStringProvider = inputStringProvider;
            CommandInvoker = commandInvoker;
        }

        public ICommand Parse(string inputString)
        {
            string inputToComper = inputString.Split(" ")[0];

            switch (inputToComper)
            {
                case "additem":
                    return new AddNewItemCommand();
                case "addstock":
                    return new AddStockCommand();
                case "removestock":
                    return new RemoveStockCommand();
                case "undo":
                    return new UndoCommand(CommandInvoker);
                case "link":
                    return new LinkToFileCommand(InputStringProvider);
                case "list":
                    return new ListWarehouseCommand();
                case "query":
                    return new QueryCommand();
                case "help":
                    return new HelpCommand();
                case "exit":
                    Log.Information("Exiting application.");
                    return new ExitCommand();
                default:
                    return null;
            }
        }
    }
}
