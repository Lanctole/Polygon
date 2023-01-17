using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Polygon.Game;
using Polygon.Game.Entities;

namespace Polygon.Controls
{
    public  class PrimaryControls
    {
        public readonly Character Character;

        public PrimaryControls(Character character)
        {
            this.Character = character;
        }

        public Dictionary<string,string> GetCharacterInfo()
        {
            {
//PropertyInfo[] props= Character.GetType().GetProperties();
                //CharacterProps props = new CharacterProps();
                //props.CharacterStats=Character.GetType().GetProperties();
                //props.WeaponStats=Character.WeaponSlot.GetType().GetProperties();
                //props.ArmorStats=Character.ArmorSlot.GetType().GetProperties();
                //var i=props.CharacterStats[0].GetValue(Character);
            }
            return  PropertiesGiver.ReturnCharacterProperties(Character);
        }

        public Dictionary<string,string> GetCharacterWeaponInfo()
        {
            return  PropertiesGiver.ReturnArmorProperties(Character.ArmorSlot);
        }

        public Dictionary<string,string> GetCharacterArmorInfo()
        {
            return  PropertiesGiver.ReturnWeaponProperties(Character.WeaponSlot);
        }
    }
}
