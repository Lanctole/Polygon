using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Game.Entities
{
    public interface ILivingCreature
    {
        int CurrentHealth{ get; set; }
        int MaxHealth { get; }
        int Level{ get; set; }
        Weapon WeaponSlot { get; set; }
        Armor ArmorSlot { get; set; }
    }
}
