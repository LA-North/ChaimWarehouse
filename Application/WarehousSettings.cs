using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using ChaimWarehouse.WarehouseFolder;

namespace ChaimWarehouse.Application
{
    internal class WarehousSettings
    {
        public static WarehousSettings GetWarehousSettings()
        {
            return null;
        }
        public static int LoadThreshold()
        {
            return int.MaxValue;
        }
    }
}
