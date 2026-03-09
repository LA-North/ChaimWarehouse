using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.WarehouseFolder
{
    /// <summary>
    /// Main class that manages all items in the warehouse.
    /// </summary>
    public class Warehouse
    {

        private static Warehouse warehouse;

        public event EventHandler<LowStockEventArgs> LowStock;

        public IDictionary<Item, int> ItemsInWarehouse { get; set; }

        private Warehouse() { }
       
        public static Warehouse GetWarehouse()
        {
           return null;
        }
        
        public void AddNewItem(Item item)
        {
            
        }
        
        public void RemoveItem(int id) { }
        
        public void AddStock(int id, int quantity)
        {
            
        }
        
        public void RemoveStock(int id, int quantity)
        {

        }
        
        public void PrintWarehouse()
        {
           
        }
        
        public void UpdateQuantity(int id) { }

        protected virtual void OnLowStock(Item item, int quantity, int threshold)
        {
          
        }



    }
}
