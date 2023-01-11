using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Entities
{
    public static class World
    {
        public static int Level { get; private set; }
        public static double WeaponToArmorStrengthAttitude { get; private set; }

        public static int PowerScaling { get; private set; }
        public static int EnemiesRange { get; private set; }

        static World()
        {
            Level = 1;
            WeaponToArmorStrengthAttitude = 1.2;
            EnemiesRange = 5;
            PowerScaling = 10;
        }

        public static void ChangeWeaponToArmorStrengthAttitude(double coefficient)
        {
            WeaponToArmorStrengthAttitude = coefficient;
        }

        public static void ChangePowerScaling(int multiplier)
        {
            PowerScaling = multiplier;
        }

        public static void ChangeEnemiesRange(int range)
        {
            EnemiesRange = range;
        }
        public static void IncreaseLevel(int amount)
        {
            World.Level += amount;
        }
    }
}
