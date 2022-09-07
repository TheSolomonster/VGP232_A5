using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    public enum ItemGroup { Consumable, Key, Equipment };
    public class Item
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public ItemGroup Group { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="group"></param>
        public Item(string name = "NA", int amount = 0, ItemGroup group = ItemGroup.Key)
        {
            Name = name;
            Amount = amount;
            Group = group;
        }

        public override string ToString()
        {
            // TODO: display the output like this Axe
            return $"{Name} [{Amount}] - {Enum.GetName(typeof(ItemGroup), Group)}";
        }
    }
}
