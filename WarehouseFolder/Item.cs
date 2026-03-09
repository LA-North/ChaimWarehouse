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
        private static int CounterId { get; set; }
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public HashSet<ItemProperty> Properties { get; set; } 
        static Item()
        {
            CounterId = 0;
        }
        public Item(string name, double price, HashSet<ItemProperty> properties) 
        {
            Id = ++CounterId;
            Name = name;
            Price = price;
            Properties = properties;
        }
        public bool HasProperty(ItemProperty prop)
        {
            return Properties.Contains(prop);
        }
        public override string ToString()
        {
            return $"<Id: {Id}, Name: {Name}, Price: {Price}, Properties: {string.Join(", ", Properties)}>";
        }
    }
}
