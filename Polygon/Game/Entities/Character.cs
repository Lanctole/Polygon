using System;
using System.Collections.Generic;
using Polygon.Entities;

namespace Polygon.Game.Entities
{
    public class Character: ILivingCreature
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; private set; }
        public long Experience { get; set; }
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
        public long LevelUpThreshold => 10000*Level +  (Level%10*1000);

        public Weapon WeaponSlot { get; set; }
        public Armor ArmorSlot { get; set; }
        public List<Item> Backpack { get; set; }

        private event EventHandler  CharacterLeveledUp;
        
        public Character()
        {
            this.Level = 1;
            this.Experience = 0;
            this.MaxHealth = 100*Level;
            this.CurrentHealth = MaxHealth;
            this.Gold = 100;
            this.WeaponSlot = new Weapon();
            this.ArmorSlot = new Armor();
            this.CharacterLeveledUp += OnLevelUp;
            this.Backpack = new List<Item>();
            this.Backpack.Capacity = 90;
            for (int i = 0; i < 2; i++)
            {
                this.Backpack.Add(new Armor());
                this.Backpack.Add(new Weapon());
            }
        }

        public Character(long experience):this()
        {
            IncreaseExperience(experience);
            for (int i = 0; i < 2; i++)
            {
                this.Backpack.Add(new Armor());
                this.Backpack.Add(new Weapon());
            }
        }

        private void OnLevelUp(object sender, EventArgs e)
        {
            this.MaxHealth += 100;
            this.CurrentHealth = this.MaxHealth;
        }

        public void IncreaseExperience(long amount)
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

        public void DecreaseExperience(long amount)
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
