using System;
using System.Collections.Generic;
using System.Text;

namespace ChaimWarehouse.WarehouseFolder
{
    /// <summary>
    /// Represents a product stored in the warehouse.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Counter used to generate unique item identifiers.
        /// </summary>
        private static int CounterId { get; set; }

        /// <summary>
        /// Unique identifier of the item.
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// The display name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The price associated with the item.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// A collection describing the item's properties.
        /// </summary>
        public HashSet<ItemProperty> Properties { get; set; }

        /// <summary>
        /// Initializes static members of the Item class.
        /// </summary>
        static Item()
        {
            CounterId = 0;
        }

        /// <summary>
        /// Creates a new item instance with the provided basic information.
        /// </summary>
        public Item(string name, double price, HashSet<ItemProperty> properties)
        {
            Id = ++CounterId;
            Name = name;
            Price = price;
            Properties = properties;
        }

        /// <summary>
        /// Checks whether the item contains a specific property.
        /// </summary>
        public bool HasProperty(ItemProperty prop)
        {
            return Properties.Contains(prop);
        }

        /// <summary>
        /// Returns a readable string representation of the item.
        /// </summary>
        public override string ToString()
        {
            return $"<Id: {Id}, Name: {Name}, Price: {Price}, Properties: {string.Join(", ", Properties)}>";
        }
    }
}
