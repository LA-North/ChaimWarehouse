using Serilog;
using System;
using System.Collections.Generic;
using System.Text;


namespace ChaimWarehouse.WarehouseFolder
{
    /// <summary>
    /// Represents the handling of the event when it's called.
    /// </summary>
    public class EventMessageService
    {
        public EventMessageService(Warehouse warehouse) 
        {
        }
        private void OnLowStock(object? sender, LowStockEventArgs e)
        {
        }
    }
}
