using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public class World
    {
        public int Level { get; set; }

        public World(Character character)
        {
            this.Level = 1;
            character.CharacterLeveledUp += OnCharacterLeveledUp;
        }

        private void OnCharacterLeveledUp(object sender, EventArgs e)
        {
            Level++;
        }
    }
}
