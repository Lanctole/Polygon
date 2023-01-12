using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polygon.Properties;

namespace Polygon
{
    public partial class MainForm : Form
    {
        public void MainScreenControlsCreate()
        {
            var menuButtonsSize = new Size(100, 50);
            bool musicIsPlaying = false;

            var playGame = new Button();
            playGame.Text = Resources.MainScreenControlsCreatePlayGame;
            playGame.Click += (sender, args) =>
            {
                this.Controls.Clear();
                StartGameControlsCreate();
            };
            this.Controls.Add(playGame);

            var glossary = new Button();
            glossary.Text = Resources.MainScreenControlsCreateGlossary;
            glossary.Click += (sender, args) =>
            {
                this.Controls.Clear();
                GlossaryControlsCreate();
            };
            this.Controls.Add(glossary);

            var exit = new Button();
            exit.Text = Resources.MainScreenControlsCreateExit;
            exit.Click +=(sender, args) => Application.Exit();
            this.Controls.Add(exit);

            
            Button[] buttons =  this.Controls.OfType<Button>().ToArray();

            var buttonsPanel = new Panel();
            buttonsPanel.AutoSize = true;
            buttonsPanel.TabStop = false;
            buttonsPanel.BackColor = Color.Black;
            buttonsPanel.Location =
                new Point(Width / 2 - menuButtonsSize.Width, Height / 2 - menuButtonsSize.Height / 2);

            foreach (var button in buttons)
            {
                button.Size=menuButtonsSize;
                button.ForeColor=Color.White;
                button.BackColor=Color.Black;
                button.Dock = DockStyle.Bottom;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                buttonsPanel.Controls.Add(button);
            }
            Controls.Add(buttonsPanel);
 

            var musicButton = new Button();
            musicButton.Text = Resources.MainScreenControlsCreatePlayMusic;
            musicButton.Size = new Size(50, 50);
            musicButton.Location = new Point(0, this.Height - musicButton.Height);
            musicButton.FlatAppearance.BorderSize = 0;
            musicButton.FlatStyle = FlatStyle.Flat;
            musicButton.Click += (sender, args) => {
                if(musicIsPlaying) {
                    MenuMusicPlayer.Stop();
                    musicButton.Text = Resources.MainScreenControlsCreatePlayMusic;
                    musicIsPlaying = false;
                } else {
                    MenuMusicPlayer.Play();
                    musicButton.Text = Resources.MainScreenControlsCreateStopMusic;
                    musicIsPlaying = true;
                }
            };
            musicButton.BackColor = Color.Black;
            musicButton.ForeColor = Color.White;
            this.Controls.Add(musicButton);

        }

    }
    
}