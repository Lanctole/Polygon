using Polygon.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Game
{
    public class Inventory
    {
        public int InventorySize;
        public Item[] Items;
        private readonly Character character;

        public Inventory(Character character)
        {
            this.character = character;
            InventorySize = character.Backpack.Capacity;
            InitializeItems(character.Backpack);
        }

        public void AddItem(Item item)
        {
            Items=Items.Concat(new Item[] { item }).ToArray();
        }

        public void InitializeItems(List<Item> backpack)
        {
            Items = new Item[character.Backpack.Capacity];
            for (int i = 0; i < character.Backpack.Count; i++)
            {
                Items[i] = character.Backpack[i];
            }
        }
    }
}
