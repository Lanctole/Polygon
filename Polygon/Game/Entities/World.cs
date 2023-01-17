using System;

namespace Polygon.Game.Entities
{
    public static class World
    {
        public enum WorldDanger
        {
            Safety=25,
            Dangerous=50,
            Fatal=75,
            Impossible=100
        }

        public static int Level { get; private set; }
        public static double WeaponToArmorStrengthAttitude { get; private set; }
        public static int PowerScaling { get; private set; }
        public static int EnemiesRange { get; private set; }
        public static Random WorldRandom = new Random();

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
