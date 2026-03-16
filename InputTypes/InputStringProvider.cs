using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.InputTypes
{
    /// <summary>
    /// Helper class that provides the next command string for the application.
    /// Or from a file or from console.
    /// </summary>
    public class InputStringProvider
    {
        public string GetNextCommandString()
        {
            //InputByConsole input  = new InputByConsole();
            //return input.GetInputString(); 
            return Console.ReadLine();
        }
    }
}
