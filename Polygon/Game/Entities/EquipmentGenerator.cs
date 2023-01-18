using Polygon.Entities;
using Polygon.Entities.MagicEffects;

namespace Polygon.Game.Entities
{
    internal static class EquipmentGenerator
    {
        public static void ItemGenerator(Item item)
        {
            var generationDecision=World.WorldRandom.Next(0, 4);
            if (generationDecision == 1)
            {
                item.MagicEffect = MagicEffectGenerator.GenerateMagicEffect();
                item.Name=item.MagicEffect.Name;
            }
               
        }
    }
}
