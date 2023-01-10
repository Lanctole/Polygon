using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public class Character
    {
        public int Hp { get; set; }
        public int Experience { get; set; }
        private int level;
        public int Level
        {
            get { return level;}
            set
            {
                Hp += 100;
                this.level=value;
            }
        }
        public event EventHandler CharacterLeveledUp;
        
        public int LevelUpThreshold
        {
            get { return 100 * (int)Math.Pow(2, Level); }
        } 

        public int Gold { get; set; }

        public Weapon WeaponSlot { get; set; }
        public Armor ArmorSlot { get; set; }
        public List<Item> Backpack { get; set; }

        public Character()
        {
            this.Backpack = new List<Item>();
            this.Experience = 0;
            this.Level = 1;
            this.Gold = 100;

            this.WeaponSlot = new Weapon { Name = "Sword", Damage = 10 };
            this.ArmorSlot = new Armor { Name = "Leather Armor", Defense = 5 };

            this.Backpack.Add(new Item { Name = "Health Potion", Value = 50 });
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
