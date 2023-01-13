using System.Drawing;
using System.Windows.Forms;

namespace Polygon.UI
{
    public partial class MainForm :Form
    {
        public MainForm()
        {
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            WindowState = FormWindowState.Maximized;
            DrawMainScreen();
        }
    }
}