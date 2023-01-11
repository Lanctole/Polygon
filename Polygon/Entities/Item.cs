using System;

namespace Polygon
{
    public class Item
    {
        public enum Rarities
        {
            Common,
            Rare,
            Legendary,
            Arcane
        }

        public string Name { get; set; }
        public int Cost { get; private set; }
        public MagicEffect magicEffect { get; set; }
        private Rarities Rarity { get; set; }

        

        public Item(string name, int cost, Rarities rarity, MagicEffect magicEffect = null)
        {
           
            Name = name;
            Cost = cost;
            Rarity = rarity;
            this.magicEffect = magicEffect;
        }

        public void SetCost(int cost)
        {
            if (cost <= 0)
                throw new ArgumentException("Cost should be greater than zero.");
            Cost = cost;
        }
    }
    
}