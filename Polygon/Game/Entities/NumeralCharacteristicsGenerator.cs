using System;
using Polygon.Entities;

namespace Polygon.Game.Entities
{
    internal static class NumeralCharacteristicsGenerator
    {
        
        public static int GenerateElementValue()
        {
            return World.Level*World.PowerScaling+World.WorldRandom.Next(1, World.PowerScaling*2);
        }

        public static int GenerateDamageValue()
        {
            return Convert.ToInt32(GenerateDefenseValue()*World.WeaponToArmorStrengthAttitude);
        }

        public static int GenerateDefenseValue()
        {
            return World.WorldRandom.Next(World.Level * World.PowerScaling / 2, World.Level * World.PowerScaling);
        }

        public static int GenerateCost(Item item)
        {
            var cost =(int)((100 * World.Level)*(1 - World.WorldRandom.Next(-2, 3) / 10.0))+World.WorldRandom.Next(1,10);
            if (item.MagicEffect !=null)
            {
                cost*=item.MagicEffect.Elements.Count;
            }
            return cost;
        }
    }
}
