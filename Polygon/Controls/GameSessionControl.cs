using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygon.Game;
using Polygon.Game.Entities;
using Polygon.UI;

namespace Polygon.Controls
{
    internal class GameSessionControl
    {
        public void NewGame(MainForm mainForm)
        {
            var primaryControls = new PrimaryControls(Start.StartNewGame());
            mainForm.DrawGameScreen(primaryControls);
        }
    }
}
