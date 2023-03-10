using Polygon.Game.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polygon.Game;
using Polygon.Controls;

namespace Polygon.UI
{
    public partial class MainForm : Form
    {
        public FlowLayoutPanel ShowInventory(PrimaryControls primaryControl)
            {
                var itemCells = new List<Button>();
                var itemCellContainer = new FlowLayoutPanel();
                itemCellContainer.WrapContents = true;
                itemCellContainer.Dock = DockStyle.Fill;
                for (int i = 0; i < primaryControl.GetInventory().InventorySize; i++)
                {
                    var itemCell = new Button();
                    itemCell.Size = new Size(50, 50);
                    itemCell.Location = new Point(i % 5 * 50, i / 5 * 50);
                    itemCell.BackColor = Color.Black;
                    itemCell.ForeColor = Color.White;
                    itemCell.FlatAppearance.BorderSize = 0;
                    itemCell.FlatStyle = FlatStyle.Flat;
                    itemCell.BackgroundImage = Properties.ImagesItems.Image2;
                    var i1 = i;
                    itemCell.Click += (sender, args) => ShowItemProperties(primaryControl.GetInventory().Items[i1],primaryControl);
                    itemCells.Add(itemCell);
                    itemCellContainer.Controls.Add(itemCell);
                }

                itemCellContainer.Visible = false;
                return itemCellContainer;
            }

        

        private void ShowItemProperties(Item item,PrimaryControls primaryControl)// переписать: убрать форму, получать данные через контрол, размеры окошка
            {
                if (item == null)
                {
                    return;
                }
                var itemPropertiesForm = new Form();
                itemPropertiesForm.Text = item.Name;
                itemPropertiesForm.Size = new Size(300, 300);
                itemPropertiesForm.StartPosition = FormStartPosition.Manual;
                itemPropertiesForm.Location = Cursor.Position;
                itemPropertiesForm.FormBorderStyle= FormBorderStyle.None;
                itemPropertiesForm.BackColor=Color.SeaGreen;
               

                var itemPropertiesList = new ListBox();
                itemPropertiesList.Dock = DockStyle.Fill;
                itemPropertiesList.Items.Add("Name: " + item.Name);
                itemPropertiesList.Items.Add("Cost: " + item.Cost);
                itemPropertiesList.Items.Add("Rarity: " + item.Rarity);
                if (item.GetType() == typeof(Weapon))
                {
                    Weapon weapon = (Weapon)item;
                    itemPropertiesList.Items.Add("Damage: " + weapon.Damage);
                    
                }
                if (item.GetType() == typeof(Armor))
                {
                    Armor armor = (Armor)item;
                    itemPropertiesList.Items.Add("Defense: " + armor.Defense);
                }

                if (item.MagicEffect != null)
                {
                    itemPropertiesList.Items.Add("Magic Effect Name: " + item.MagicEffect.Name);
                    itemPropertiesList.Items.Add("Magic Effect Strength: " + item.MagicEffect.Strength);
                    //itemPropertiesList.Items.Add("Magic Effect Elements:" + item.MagicEffect.Elements.ToArray());
                }
                itemPropertiesForm.Controls.Add(itemPropertiesList);

                var equipButton = new Button();
                equipButton.Text = "Equip";
                equipButton.Dock = DockStyle.Bottom;
                equipButton.Click += (sender, args) =>
                {
                    primaryControl.SetItemInCharacterSlot(item);
                    itemPropertiesForm.Close();
                };
                itemPropertiesForm.Controls.Add(equipButton);
                itemPropertiesForm.AutoSize=true;
                itemPropertiesForm.AutoSizeMode=AutoSizeMode.GrowOnly;
                itemPropertiesForm.ShowDialog();
            }
    }
}
