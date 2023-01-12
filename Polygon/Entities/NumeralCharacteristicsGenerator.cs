using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Entities
{
    internal static class NumeralCharacteristicsGenerator
    {
        public static int GenerateElementValue()
        {
            var random = new Random();
            return World.Level*World.PowerScaling+random.Next(1, World.PowerScaling*2);
        }

        public static int GenerateDamageValue()
        {
            return Convert.ToInt32(GenerateDefenseValue()*World.WeaponToArmorStrengthAttitude);
        }
        public static int GenerateDefenseValue()
        {
            var random = new Random();
            return random.Next(World.Level * World.PowerScaling / 2, World.Level * World.PowerScaling);
        }

        public static int GenerateCost(Item item)
        {
            var random = new Random();
            int numOfEffects=item.MagicEffect.Elements.Count;
            var cost =(int)((100 + World.Level)*(1-random.Next(-2,3)/10));
            if (numOfEffects > 0)
            {
                cost*=numOfEffects;
            }
            return cost;
        }
    }
}
