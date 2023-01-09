using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Polygon
{
    public partial class MainForm :Form
    {
        private readonly ResourceManager resourceManager =
            new ResourceManager("Polygon.Resources.Resources", typeof(MainForm).Assembly);

        public MainForm()
        {
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            //TopMost = true;
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            WindowState = FormWindowState.Maximized;

            MainScreenControlsCreate();
        }

       
    }
}