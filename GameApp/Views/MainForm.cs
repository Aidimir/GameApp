using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameApp.Views;
using GameApp.models;
using System.Media;
namespace GameApp.Views
{
    public partial class MainForm : Form
    {
        private Game game;
        private Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
        private MusicPlayer musicPlayer;
        public MainForm()
        {
            InitializeComponent();
            game = new Game();
            game.StageChanged += Game_OnStageChanged;
            musicPlayer = new MusicPlayer();
            ShowStart();
        }
        private void Game_OnStageChanged(GameStage stage)
        {
            switch (stage)
            {
                case GameStage.Finished:
                    ShowFinish();
                    break;
                case GameStage.IsPlaying:
                    ShowGame();
                    break;
                case GameStage.NotStarted:
                    ShowStart();
                    break;
            }
        }
        private void HideAll()
        {
            startControl1.Hide();
            gameScreen1.Hide();
            finishScreen1.Hide();
        }
        private void ShowGame()
        {
            HideAll();
            gameScreen1.Size = screenSize;
            gameScreen1.Configure(game);
            if (musicPlayer.IsPlaying)
            {
                musicPlayer.Stop();
            }
            musicPlayer.Start();
            gameScreen1.Show();
        }
        private void ShowStart()
        {
            HideAll();
            startControl1.Size = screenSize;
            startControl1.Configure(game);
            if (musicPlayer.IsPlaying)
            {
                musicPlayer.Stop();
            }
            else
            {
                musicPlayer.Start();
            }
            startControl1.Show();
        }
        private void ShowFinish()
        {
            HideAll();
            finishScreen1.Size = screenSize;
            finishScreen1.Configure(game);
            finishScreen1.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void gameScreen1_Load(object sender, EventArgs e)
        {

        }
    }
}
