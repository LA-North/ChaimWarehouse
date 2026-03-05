using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Application
{
    /// <summary>
    /// This class loads configuration values from the appsettings.json file,
    /// Like low stock threshold used to trigger warehouse alerts.
    /// </summary>
    public class WarehouseSettings
    {
        private static WarehouseSettings warehouseSettings;

        /// <summary>
        /// Returns the single instance of the WarehousSettings class.
        /// </summary>
        public static WarehouseSettings GetWarehousSettings()
        {
            return null;
        }

        /// <summary>
        /// Reads the low stock threshold value from the configuration file.
        /// The threshold is the minimum quantity allowed in warehouse Item. 
        /// </summary>
        public static int LoadThreshold()
        {
            return int.MaxValue;
        }
    }
}
