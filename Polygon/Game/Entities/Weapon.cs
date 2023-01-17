using System;
using Polygon.Entities.MagicEffects;

namespace Polygon.Game.Entities
{
    public class Weapon :Item
    {
        public int Damage { get; set; }
        protected string[] WeaponTypes = new string[]
        {
            "sword",
            "lance",
            "bow",
            "long-sword"
        };
        public Weapon(string name, int damage, int cost, Rarities rarity, MagicEffect magicEffect = null) : 
            base(name, cost, rarity, magicEffect)
        {
            Damage = damage;
        }

        public Weapon() : base()
        {
            Damage = NumeralCharacteristicsGenerator.GenerateDamageValue();
            Name += WeaponTypes[World.WorldRandom.Next(0, WeaponTypes.Length)];
        }
    }
}