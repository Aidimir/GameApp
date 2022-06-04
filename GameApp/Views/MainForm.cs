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

namespace GameApp.Views
{
    public partial class MainForm : Form
    {
        private Game game;
        private int ticks = 0;
        private bool timeDidPass = false;
        public MainForm()
        {
            InitializeComponent();
            game = new Game();
            game.StageChanged += Game_OnStageChanged;
            ShowStart();
        }
        private void Game_OnStageChanged(GameStage stage)
        {
            switch (stage)
            {
                case GameStage.Finished:
                    ShowStart();
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
        }
        private void ShowGame()
        {
            HideAll();
            gameScreen1.Configure(game);
            gameScreen1.Show();
        }
        private void ShowStart()
        {
            HideAll();
            startControl1.Configure(game);
            startControl1.Show();
        }
        private void ShowFinish()
        {
            HideAll();
            
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
