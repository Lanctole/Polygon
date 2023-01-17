using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Polygon.Controls;
using Polygon.Properties;

namespace Polygon.UI
{
    public partial class MainForm : Form
    {
        public void DrawMainScreen()
        {
            var menuButtonsSize = new Size(100, 50);
            bool musicIsPlaying = false;

            CreatePlayGameButton();
            CreateGlossaryButton();
            CreateExitButton();
            Button[] buttons =  this.Controls.OfType<Button>().ToArray();

            var buttonsPanel = new Panel();
            buttonsPanel.AutoSize = true;
            buttonsPanel.TabStop = false;
            buttonsPanel.BackColor = Color.Black;
            buttonsPanel.Location =
                new Point(Width / 2 - menuButtonsSize.Width, Height / 2 - menuButtonsSize.Height / 2);

            foreach (var button in buttons)
            {
                ChangeButtonProperties(button);
            }
            Controls.Add(buttonsPanel);
            
            var musicButton = new Button();
            musicButton.Text = Resources.MainScreenControlsCreatePlayMusic;
            musicButton.Size = new Size(50, 50);
            musicButton.Location = new Point(0, this.Height - musicButton.Height);
            musicButton.FlatAppearance.BorderSize = 0;
            musicButton.FlatStyle = FlatStyle.Flat;
            musicButton.BackColor = Color.Black;
            musicButton.ForeColor = Color.White;
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
            Controls.Add(musicButton);

            void CreatePlayGameButton()
            {
                var playGame = new Button();
                playGame.Text = Resources.MainScreenControlsCreatePlayGame;
                playGame.Click += (sender, args) =>
                {
                    Controls.Clear();
                    var newGame = new GameSessionControl();
                    newGame.NewGame(this);
                };
                Controls.Add(playGame);
            }

            void CreateGlossaryButton()
            {
                var glossary = new Button();
                glossary.Text = Resources.MainScreenControlsCreateGlossary;
                glossary.Click += (sender, args) =>
                {
                    Controls.Clear();
                    DrawGlossary();
                };
                Controls.Add(glossary);
            }

            void CreateExitButton()
            {
                var exit = new Button();
                exit.Text = Resources.MainScreenControlsCreateExit;
                exit.Click += (sender, args) => Application.Exit();
                Controls.Add(exit);
            }

            void ChangeButtonProperties(Button button)
            {
                button.Size = menuButtonsSize;
                button.ForeColor = Color.White;
                button.BackColor = Color.Black;
                button.Dock = DockStyle.Bottom;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                buttonsPanel.Controls.Add(button);
            }
        }
    }
}