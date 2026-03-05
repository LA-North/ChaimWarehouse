using Serilog;
using System;
using System.Collections.Generic;
using System.Text;


namespace ChaimWarehouse.WarehouseFolder
{
    /// <summary>
    /// Represents the handleing of the event whan it's called.
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
