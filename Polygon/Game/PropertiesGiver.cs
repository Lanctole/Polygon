using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygon.Entities.MagicEffects;
using Polygon.Game.Entities;

namespace Polygon.Game
{
    public static class PropertiesGiver
    {
        public static Dictionary<string, string> ReturnCharacterProperties(Character character)
        {
            Dictionary<string, string> charProps = new Dictionary<string, string>
            {
                { "Gold", character.Gold.ToString() },
                { "Experience", character.Experience.ToString()+"/"+ character.LevelUpThreshold.ToString()}
            };
            charProps =charProps.Concat(ReturnLivingCreatureProperties(character))
                .ToDictionary(x=>x.Key, x=>x.Value);
            return charProps;
        }

        private static Dictionary<string, string> ReturnLivingCreatureProperties(ILivingCreature creature)
        {
            Dictionary<string, string> livingCreatureProps = new Dictionary<string, string>
            {
                { "Level", creature.Level.ToString() },
                { "Current Health", creature.CurrentHealth.ToString()+"/"+creature.MaxHealth.ToString() },
            };
            return livingCreatureProps;
        }

        public static Dictionary<string, string> ReturnWeaponProperties(Weapon weapon)
        {
            Dictionary<string, string> weaponProps = new Dictionary<string, string>
            {
                { "Weapon Name", weapon.Name },
                { "Damage", weapon.Damage.ToString() },
                { "Weapon Rarity", weapon.Rarity.ToString() },
                { "Weapon Cost", weapon.Cost.ToString() }
            };
            if (weapon.MagicEffect != null)
            {
                weaponProps =weaponProps.Concat(ReturnMagicEffectProperties(weapon.MagicEffect))
                    .ToDictionary(x=>x.Key, x=>x.Value);
            }
            return weaponProps;
        }

        public static Dictionary<string, string> ReturnArmorProperties(Armor armor)
        {
            Dictionary<string, string> armorProps = new Dictionary<string, string>
            {
                { "Armor Name", armor.Name },
                { "Defense", armor.Defense.ToString() },
                { "Armor Rarity", armor.Rarity.ToString() },
                { "Armor Cost", armor.Cost.ToString() }
            };
            if (armor.MagicEffect != null)
            {
                armorProps =armorProps.Concat(ReturnMagicEffectProperties(armor.MagicEffect))
                    .ToDictionary(x=>x.Key, x=>x.Value);
            }
            return armorProps;
        }

        public static Dictionary<string, string> ReturnMagicEffectProperties(MagicEffect magicEffect)
        {
            Dictionary<string, string> magicEffectProps = new Dictionary<string, string>
            {
                { "Magic Effect Name", magicEffect.Name },
                { "Strength", magicEffect.Strength.ToString() }
            };
            return magicEffectProps;
        }
    }
}
