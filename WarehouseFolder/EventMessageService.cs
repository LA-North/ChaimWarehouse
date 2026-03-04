using Serilog;
using System;
using System.Collections.Generic;
using System.Text;


namespace ChaimWarehouse.WarehouseFolder
{
    internal class EventMessageService
    {
        public EventMessageService(Warehouse warehouse) 
        {
        }
        private void OnLowStock(object? sender, LowStockEventArgs e)
        {
        }
    }
}
