using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
            var panelBorderThickness = 4;

            var equippedItemsPanel = new Panel();
            equippedItemsPanel.Size = new Size(110, 110 );
            equippedItemsPanel.Location = new Point(this.Width / 2 - 200 , 10 );
            equippedItemsPanel.BackColor = Color.Black;
            equippedItemsPanel.Visible=false;
            var equippedItems = ShowEquipped(primaryControl);
            equippedItemsPanel.Controls.Add(equippedItems);
            this.Controls.Add(equippedItemsPanel);

            var characterStatsPanel =ShowCharacter(primaryControl);
            characterStatsPanel.Location = new Point(equippedItemsPanel.Location.X, equippedItemsPanel.Location.Y + 100);
            Controls.Add(characterStatsPanel);

            var inventoryPanel = new Panel();
            inventoryPanel.Size = new Size(this.Width / 2 - panelBorderThickness*2, this.Height / 2 - panelBorderThickness);
            inventoryPanel.Location = new Point(this.Width / 2 + panelBorderThickness , 10 + panelBorderThickness);
            inventoryPanel.BackColor = Color.Black;
            inventoryPanel.Visible=false;
            var inventory = ShowInventory(primaryControl);
            inventoryPanel.Controls.Add(inventory);
            this.Controls.Add(inventoryPanel);

            var borderPanel = new Panel();
            borderPanel.Size = new Size(this.Width / 2 +panelBorderThickness, 
                this.Height/2 + panelBorderThickness);
            borderPanel.BackColor=Color.PaleVioletRed;
            borderPanel.Location = new Point(this.Width / 2 , 10);
            borderPanel.Visible = false;
            Controls.Add(borderPanel);

            var characterMenu = new Button();
            characterMenu.Text = Resources.Character;
            characterMenu.Size = buttonSize;
            characterMenu.Click += (sender, args)=>
            {
                characterStatsPanel.Visible = !characterStatsPanel.Visible;
                inventory.Visible = !inventory.Visible;
                inventoryPanel.Visible = !inventoryPanel.Visible;
                borderPanel.Visible = !borderPanel.Visible;
                equippedItemsPanel.Visible = !equippedItemsPanel.Visible;
                equippedItems.Visible = !equippedItems.Visible;
            };

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
            //startBattle.Click += (sender, args) => StartBattle();
            startBattle.BackColor = Color.Black;
            startBattle.ForeColor = Color.White;
            startBattle.FlatAppearance.BorderSize = 0;
            startBattle.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(startBattle);

        }
    }
}
