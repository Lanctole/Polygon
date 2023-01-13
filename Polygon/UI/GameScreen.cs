using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Polygon.Controls;
using Polygon.Game;
using Polygon.Game.Entities;
using Polygon.Properties;

namespace Polygon.UI
{
    public partial class MainForm : Form
    {
        public void DrawGameScreen(PrimaryControls primaryControl)
        {
            var buttonSize = new Size(100, 50);
            
            var characterMenu = new Button();
            characterMenu.Text = Resources.Character;
            characterMenu.Size = buttonSize;
            characterMenu.Click += (sender, args) => ShowCharacter();
            this.Controls.Add(characterMenu);

            var backToMainMenu = new Button();
            backToMainMenu.Text = Resources.StartGameControlsCreateBacktoMainMenu;
            backToMainMenu.Size = buttonSize;
            backToMainMenu.Click += (sender, args) =>
            {
                this.Controls.Clear();
                DrawMainScreen();
            };
            this.Controls.Add(backToMainMenu);

            Button[] buttons =  this.Controls.OfType<Button>().ToArray();

            var buttonsPanel = new Panel();
            buttonsPanel.AutoSize = true;
            buttonsPanel.TabStop = false;
            buttonsPanel.BackColor = Color.Black;
            buttonsPanel.Location = new Point(this.Width - (buttonSize.Width * 2 + 20), this.Height - buttonSize.Height*buttons.Length);

            foreach (var button in buttons)
            {
                button.Size=buttonSize;
                button.ForeColor=Color.White;
                button.BackColor=Color.Black;
                button.Dock = DockStyle.Bottom;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                buttonsPanel.Controls.Add(button);
            }
            Controls.Add(buttonsPanel);

            var startBattle = new Button();
            startBattle.Text = Resources.StartGameControlsCreateStartBattle;
            startBattle.Size = buttonSize;
            startBattle.Location = new Point(0, this.Height - startBattle.Height);
            startBattle.Click += (sender, args) => StartBattle();
            startBattle.BackColor = Color.Black;
            startBattle.ForeColor = Color.White;
            startBattle.FlatAppearance.BorderSize = 0;
            startBattle.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(startBattle);

            void StartBattle() { /* start battle logic*/ }

            void ShowCharacter()
            {
                var properties = primaryControl.GetCharacterInfo();
                var labels = new List<Label>();
                var y = 0;
                foreach (var property in properties)
                {
                    var label = new Label
                    {
                        Text = $"{property.Name}: {property.GetValue(primaryControl.character)}",
                        Location = new Point(0, y),
                        AutoSize = true
                    };
                    label.ForeColor=Color.White;
                    label.BackColor=Color.Black;
                    labels.Add(label);
                    y += label.Height;
                }
                var panel = new Panel
                {
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                panel.ForeColor=Color.White;
                panel.BackColor=Color.Black;
                foreach (var label in labels)
                {
                    panel.Controls.Add(label);
                }
                this.Controls.Add(panel);
            }
        }
    }
}
