using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.WarehouseFolder
{
    /// <summary>
    /// Event arguments for when an item's stock goes below the threshold.
    /// </summary>
    public class LowStockEventArgs : EventArgs
    {
        public LowStockEventArgs(Item item, int quantity, int threshold)
        {
           
        }
    }
}
