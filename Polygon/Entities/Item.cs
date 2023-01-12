using System;
using Polygon.Entities.MagicEffects;

namespace Polygon.Entities
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
        public MagicEffect MagicEffect { get; set; }
        protected Rarities Rarity { get; set; }


        public Item()
        {
            if (World.Level >= (int)World.WorldDanger.Safety)
            {
                EquipmentGenerator.ItemGenerator(this);
            }
            else
                MagicEffect = null;

            if (MagicEffect != null)
            {
                switch (MagicEffect.Elements.Count)
                {
                    case 1:
                        Rarity = Rarities.Rare;
                        break;
                    case 2:
                        Rarity= Rarities.Legendary;
                        break;
                    case 3:
                        Rarity = Rarities.Arcane;
                        break;
                }
            }
            else 
                Rarity = Rarities.Common;

            SetCost(NumeralCharacteristicsGenerator.GenerateCost(this));
            
        }
        public Item(string name, int cost, Rarities rarity, MagicEffect magicEffect = null)
        {
            Name = name;
            SetCost(cost);
            Rarity = rarity;
            this.MagicEffect = magicEffect;
        }

        protected void SetCost(int cost)
        {
            if (cost <= 0)
                throw new ArgumentException("Cost should be greater than zero.");
            Cost = cost;
        }
        
    }
    
}