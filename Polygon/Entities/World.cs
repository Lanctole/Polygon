using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public static class World
    {
        public static int Level { get; set; }

        public static void IncreaseLevel(int amount)
        {
            World.Level += amount;
        }
    }
}
