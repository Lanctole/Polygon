using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Polygon
{
    public partial class MainForm :Form
    {
        public MainForm()
        {
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            //TopMost = true;
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            WindowState = FormWindowState.Maximized;

            //MenuMusicPlayer.Play();
            MainScreenControlsCreate();
        }
    }
}