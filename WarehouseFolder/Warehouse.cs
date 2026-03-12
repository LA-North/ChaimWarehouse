using ChaimWarehouse.Application;
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
        /// <summary>
        /// Holds the single instance of the warehouse.
        /// </summary>
        public static Warehouse Instance { get; }

        /// <summary>
        /// Event raised when an item reaches a low stock condition.
        /// </summary>
        public event EventHandler<LowStockEventArgs> LowStock;

        /// <summary>
        /// Collection that stores the items and their current quantities.
        /// </summary>
        public IDictionary<Item, int> ItemsInWarehouse { get; }

        /// <summary>
        /// Settings property to hold the configuration values for the warehouse, such as low stock threshold.
        /// </summary>
        public WarehouseSettings Settings { get; set; }

        /// <summary>
        /// Private constructor to Initialize instance inside the class.
        /// </summary>
        private Warehouse() { }

        /// <summary>
        /// Initializes the singleton instance of the Warehouse class 
        /// before any static members are accessed or any  instances are created.
        /// </summary>
        static Warehouse()
        {
            Instance = new Warehouse();
        }

        /// <summary>
        /// Adds a new item to the warehouse.
        /// </summary>
        /// <param name="item">The item to add to the warehouse.</param>
        public void AddNewItem(Item item)
        {

        }

        /// <summary>
        /// Removes an item from the warehouse.
        /// </summary>
        /// <param name="id">The item id to remove from the warehouse.</param>
        public void RemoveItem(int id) { }

        /// <summary>
        /// Increases the quantity of an existing item.
        /// </summary>
        /// <param name="id">The identifier of the item whose quantity going to be add.</param>
        /// <param name="quantity">The quantity to add.</param>
        public void AddStock(int id, int quantity)
        {

        }

        /// <summary>
        /// Decreases the quantity of an existing item.
        /// </summary>
        /// <param name="id">The identifier of the item whose quantity going to be remove.</param>
        /// <param name="quantity">The quantity to remove.</param>
        public void RemoveStock(int id, int quantity)
        {

        }

        /// <summary>
        /// Displays the current state of the warehouse.
        /// </summary>
        public void PrintWarehouse()
        {

        }

        /// <summary>
        /// Evaluates the quantity of an item in the warehouse and triggers the LowStock event
        /// if the quantity falls below the configured threshold.
        /// </summary>
        /// <param name="id">The identifier of the item whose quantity was changed.</param>
        public void CheckAndNotifyLowStock(int id) { }

        /// <summary>
        /// Raises the LowStock event when a low stock condition occurs by calling the OnLowStock function.
        /// </summary>
        /// <param name="item">The item that his quantity is below the threshold.</param>
        /// <param name="quantity">What quantity trying to be changed.</param>
        /// <param name="threshold">The threshold that read from the configuration file.</param>
        protected virtual void OnLowStock(Item item, int quantity, int threshold)
        {

        }
    }
}
