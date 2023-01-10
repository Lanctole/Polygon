using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon
{
    public partial class MainForm : Form
    {
        public void MainScreenControlsCreate()
        {
            var menuButtonsSize = new Size(100, 50);

            var playGame = new Button();
            playGame.Text = resourceManager.GetString("playGame");
            this.Controls.Add(playGame);

            var glossary = new Button();
            glossary.Text = resourceManager.GetString("glossary");
            glossary.Click += (sender, args) =>
            {
                this.Controls.Clear();
                GlossaryControlsCreate();
            };
            this.Controls.Add(glossary);

            var exit = new Button();
            exit.Text = resourceManager.GetString("exit");
            exit.Click +=(sender, args) => Application.Exit();
            this.Controls.Add(exit);

            Button[] buttons =  this.Controls.OfType<Button>().ToArray();

            var buttonsPanel = new Panel();
            buttonsPanel.AutoSize = true;
            buttonsPanel.TabStop = false;
            buttonsPanel.BackColor = Color.Black;
            buttonsPanel.AutoSize = true;
            buttonsPanel.Location =
                new Point(Width / 2 - menuButtonsSize.Width, Height / 2 - menuButtonsSize.Height / 2);

            foreach (var button in buttons)
            {
                button.Size=menuButtonsSize;
                button.ForeColor=Color.White;
                button.BackColor=Color.Black;
                button.Dock = DockStyle.Bottom;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                buttonsPanel.Controls.Add(button);
            }
            Controls.Add(buttonsPanel);
        }

    }
    
}