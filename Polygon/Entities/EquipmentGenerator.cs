using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygon.Entities.MagicEffects;

namespace Polygon.Entities
{
    internal static class EquipmentGenerator
    {
        public static void ItemGenerator(Item item)
        {
            item.MagicEffect = MagicEffectGenerator.GenerateMagicEffect();
            item.Name=item.MagicEffect.Name;
        }
    }
}
