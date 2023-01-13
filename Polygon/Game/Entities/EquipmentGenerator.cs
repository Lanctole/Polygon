using Polygon.Entities;
using Polygon.Entities.MagicEffects;

namespace Polygon.Game.Entities
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
