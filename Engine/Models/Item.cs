using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(int itemID, string name, int price) 
        { 
            ItemID = itemID;
            Name = name;
            Price = price;
        }

        public Item Clone() 
        { 
            return new Item(ItemID, Name, Price);
        }
    }
}
