using System;
using Polygon.Entities;
using Polygon.Entities.MagicEffects;

namespace Polygon.Game.Entities
{
    public class Armor :Item
    {
        public int Defense { get; set; }
        public Armor(string name, int defense, int cost, Rarities rarity, MagicEffect magicEffect = null) : 
            base(name, cost, rarity, magicEffect)
        {
            Name=name;
            Defense = defense;
            SetCost(cost);
            Rarity = rarity;
            MagicEffect = magicEffect;
        }

        protected string[] ArmorTypes = new string[]
        {
            "gambeson",
            "platemail",
            "chainmale"
        };

        public Armor():base()
        {
            Defense = NumeralCharacteristicsGenerator.GenerateDefenseValue();
            Name += ArmorTypes[World.WorldRandom.Next(0, ArmorTypes.Length)];
            
        }
    }
}