using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.InputTypes
{
    /// <summary>
    /// An interface for sources of strings that represent commands. 
    /// </summary>
    public interface IInputStringGetter
    {
        string GetInputString();
    }
}
