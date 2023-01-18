using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Polygon.Controls;
using Polygon.Properties;

namespace Polygon.UI
{
    public partial class MainForm : Form
    {
        public FlowLayoutPanel ShowEquipped(PrimaryControls primaryControl)
        {
            var itemCellContainer = new FlowLayoutPanel();
            itemCellContainer.WrapContents = false;
            itemCellContainer.Dock = DockStyle.Fill;

            var itemCellWeapon = new Button();
                itemCellWeapon.Size = new Size(50, 50);
                itemCellWeapon.Location = new Point( 1 * 50, 1 * 50);
                itemCellWeapon.BackColor = Color.Black;
                itemCellWeapon.ForeColor = Color.White;
                itemCellWeapon.FlatAppearance.BorderSize = 0;
                itemCellWeapon.FlatStyle = FlatStyle.Flat;
                itemCellWeapon.BackgroundImage = ImagesItems.Image1;
                itemCellWeapon.Click += (sender, args) => ShowItemProperties(primaryControl.GetCharacterWeapon(),primaryControl);
                
                var itemCellArmor = new Button();
                itemCellArmor.Size = new Size(50, 50);
                itemCellArmor.Location = new Point( 2 * 50, 2 * 50);
                itemCellArmor.BackColor = Color.Black;
                itemCellArmor.ForeColor = Color.White;
                itemCellArmor.FlatAppearance.BorderSize = 0;
                itemCellArmor.FlatStyle = FlatStyle.Flat;
                itemCellArmor.BackgroundImage = ImagesItems.Image2;
                itemCellArmor.Click += (sender, args) => ShowItemProperties(primaryControl.GetCharacterArmor(), primaryControl);

                itemCellContainer.Controls.Add(itemCellWeapon);
                itemCellContainer.Controls.Add(itemCellArmor);
            

            itemCellContainer.Visible = false;
            return itemCellContainer;
        }
    }
}