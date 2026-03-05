using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.InputTypes
{
    /// <summary>
    /// Interface for classes that provide input strings.
    /// Allows the application to support different input sources like console or files.
    /// </summary>
    public interface IInputStringGetter
    {
        string GetInputString();
    }
}
