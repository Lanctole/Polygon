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
            public void GlossaryControlsCreate()
            {
                var back = new Button();
                back.Text = "Назад";
                back.Size = new Size(50, 50);
                back.ForeColor=Color.White;
                back.BackColor=Color.Black;
                back.Location=new Point(Width-Width+5,Height-100);
                //back.Dock = DockStyle.Left;
                back.FlatAppearance.BorderSize = 0;
                back.FlatStyle = FlatStyle.Flat;
                back.FlatAppearance.MouseDownBackColor = Color.DimGray;
                back.Click += (sender, args) =>
                {
                    this.Controls.Clear();
                    MainScreenControlsCreate();
                };
                Controls.Add(back);
            }

        }
    
}
