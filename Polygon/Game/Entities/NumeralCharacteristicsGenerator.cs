using System;
using Polygon.Entities;

namespace Polygon.Game.Entities
{
    internal static class NumeralCharacteristicsGenerator
    {
        static Random random = new Random();
        public static int GenerateElementValue()
        {
            return World.Level*World.PowerScaling+random.Next(1, World.PowerScaling*2);
        }

        public static int GenerateDamageValue()
        {
            return Convert.ToInt32(GenerateDefenseValue()*World.WeaponToArmorStrengthAttitude);
        }

        public static int GenerateDefenseValue()
        {
            return random.Next(World.Level * World.PowerScaling / 2, World.Level * World.PowerScaling);
        }

        public static int GenerateCost(Item item)
        {
            var cost =(int)((100 + World.Level)*(1 - random.Next(-2, 3) / 10.0))+random.Next(1,10);
            if (item.MagicEffect !=null)
            {
                cost*=item.MagicEffect.Elements.Count;
            }
            return cost;
        }
    }
}
