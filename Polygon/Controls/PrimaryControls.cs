using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Polygon.Game.Entities;

namespace Polygon.Controls
{
    public  class PrimaryControls
    {
        public Character character;

        public PrimaryControls(Character character)
        {
            this.character = character;
        }

        public PropertyInfo[] GetCharacterInfo()
        {
            return character.GetType().GetProperties();
        }
    }
}
