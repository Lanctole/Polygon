using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    internal static class MenuMusicPlayer
    {
        public static void Play()
        {
            try
            {
                SoundPlayer backgroundSound = new SoundPlayer(Properties.Music.MenuSound);
                backgroundSound.PlayLooping();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Background sound file not found");
            }
        }
    }
}
