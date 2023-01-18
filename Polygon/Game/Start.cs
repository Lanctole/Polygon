using Polygon.Game.Entities;

namespace Polygon.Game
{
    public static class Start
    {
        public static Character StartNewGame()
        {
            World.SetLevel(1);
            return new Character(10000000);
        }
    }
}
