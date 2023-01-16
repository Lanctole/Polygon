using System;
using System.Collections.Generic;
using Polygon.Entities;

namespace Polygon.Game.Entities
{
    public class Character: ILivingCreature
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; private set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        private int level;
        public int Level
        {
            get => level;
            set
            {
                this.level=value;
                CharacterLeveledUp?.Invoke(this,EventArgs.Empty);
            }
        }
        public int LevelUpThreshold => 100 * (int)Math.Pow(2, Level);

        public Weapon WeaponSlot { get; set; }
        public Armor ArmorSlot { get; set; }
        public List<Item> Backpack { get; set; }

        private event EventHandler  CharacterLeveledUp;
        
        public Character()
        {
            this.Backpack = new List<Item>();
            this.Experience = 0;
            this.Level = 1;
            this.CurrentHealth = MaxHealth;
            this.Gold = 100;
            this.WeaponSlot = new Weapon();
            this.ArmorSlot = new Armor();
            this.CharacterLeveledUp += OnLevelUp;
        }
        private void OnLevelUp(object sender, EventArgs e)
        {
            this.MaxHealth += 100;
            this.CurrentHealth = this.MaxHealth;
        }
        public void IncreaseExperience(int amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.Experience += amount;
                }
            }
            finally
            {
                while (true)
                {
                    if (this.Experience >= LevelUpThreshold)
                    {
                        this.Experience -= LevelUpThreshold;
                        this.Level++;
                        World.IncreaseLevel(1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void DecreaseExperience(int amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.Experience -= amount;
                }
            }
            finally
            {
                
            }
        }
    }
}
