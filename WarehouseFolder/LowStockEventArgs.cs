using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.WarehouseFolder
{
    internal class LowStockEventArgs : EventArgs
    {
        public LowStockEventArgs(Item item, int quantity, int threshold)
        {
           
        }
    }
}
