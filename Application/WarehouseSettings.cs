using ChaimWarehouse.WarehouseFolder;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ChaimWarehouse.Application
{
    /// <summary>
    /// This class loads configuration values,
    /// Like low stock threshold used to trigger warehouse alerts.
    /// </summary>
    public class WarehouseSettings
    {
        /// <summary>
        /// Reads the low stock threshold value from the configuration file.
        /// The threshold is the minimum quantity allowed in warehouse Item. 
        /// </summary>
        public int LowStockThreshold { get; set; }
    }
}
