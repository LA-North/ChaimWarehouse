using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.InputTypes
{
    /// <summary>
    /// Input implementation that reads commands directly from the console.
    /// </summary>
    public class InputByConsole : IInputStringGetter
    {
        public string GetInputString()
        {
            
            return "input";
        }
    }
}
