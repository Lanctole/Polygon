using System.Drawing;
using System.Windows.Forms;

namespace Polygon
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            TopMost = true;
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            WindowState = FormWindowState.Maximized;
        }
    }
}