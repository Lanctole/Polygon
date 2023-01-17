using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Polygon.Controls;

namespace Polygon.UI
{
    public partial class MainForm : Form
    {
        public Panel ShowCharacter(PrimaryControls primaryControl)
        {
            var properties = primaryControl.GetCharacterInfo();
            var labels = new List<Label>();
            var y = 0;
            
            
            foreach (var property in properties)
            {
                var label = new Label
                {
                    Text = $"{property.Key}: {property.Value}",
                    Location = new Point(0, y),
                    AutoSize = true
                };
                label.ForeColor = Color.White;
                label.BackColor = Color.Black;
                labels.Add(label);
                y += label.Height;
            }

            //properties = primaryControl.GetCharacterWeaponInfo();
            //foreach (var property in properties)
            //{
            //    var label = new Label
            //    {
            //        Text = $"{property.Key}: {property.Value}",
            //        Location = new Point(0, y),
            //        AutoSize = true
            //    };
            //    label.ForeColor = Color.White;
            //    label.BackColor = Color.Black;
            //    labels.Add(label);
            //    y += label.Height;
            //}

            //properties = primaryControl.GetCharacterArmorInfo();
            //foreach (var property in properties)
            //{
            //    var label = new Label
            //    {
            //        Text = $"{property.Key}: {property.Value}",
            //        Location = new Point(0, y),
            //        AutoSize = true
            //    };
            //    label.ForeColor = Color.White;
            //    label.BackColor = Color.Black;
            //    labels.Add(label);
            //    y += label.Height;
            //}

            var panel = new Panel
            {
                AutoSize = true,
                Location = new Point(10, 10)
            };
            panel.ForeColor = Color.White;
            panel.BackColor = Color.Black;
            foreach (var label in labels) panel.Controls.Add(label);
            panel.Visible = false;
            return panel;
        }
    }
}