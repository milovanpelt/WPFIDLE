using Engine.Models;
using Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<Item> _items = new List<Item>();

        static ItemFactory() 
        {
            _items.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _items.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
        }

        public static Item CreateItem(int itemID) 
        {
            Debug.Assert(_items != null, $"[{nameof(ItemFactory)}]: Item list not unitialized"); 

            Item newItem = _items.FirstOrDefault(item => item.ItemID == itemID);

            if (newItem == null) 
            {

                return null;
            }

            return newItem.Clone();
        }
    }
}
