using Polygon.Entities.MagicEffects;
using System;

namespace Polygon.Entities
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
            var random = new Random();
            Name += WeaponTypes[random.Next(0, WeaponTypes.Length)];
        }
    }
}