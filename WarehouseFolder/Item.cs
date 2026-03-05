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
        private static int CounterId { get; set; } = 0;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public HashSet<ItemProperty> Properties { get; set; } 
        public Item(string Name, double Price, HashSet<ItemProperty> Properties) 
        {
            this.Id = ++CounterId;
            this.Name = Name;
            this.Price = Price;
            this.Properties = Properties;
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
