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
    public partial class GameScreen : UserControl
    {
        private int ticks = 0;
        private Game? game;
        public Bitmap TargetTexure = Resource1.target;
        Random random = new Random();
        private Point _targetPosition = new Point(300, 300);
        private Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
        private int TargetTextureSize = 50;
        private bool DidHit = false;
        private int Rate = 200;

        public GameScreen()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(new Bitmap(Resource1.mouse1), 50, 50);
            this.Cursor = new Cursor(bmp.GetHicon());
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        public void Configure(Game game)
        {
            this.game = game;
            timer1.Start();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(TargetTexure, new Rectangle(_targetPosition.X, _targetPosition.Y,TargetTextureSize,TargetTextureSize));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            TimerTextBox.Text = $"время : {180 - ticks/40}";
            ScoreTextBox.Text = game.score.ToString() ;
            var localPosition = this.PointToClient(Cursor.Position);
            Point between = new Point(localPosition.X - _targetPosition.X, localPosition.Y - _targetPosition.Y);
            float distance = (float)Math.Sqrt((between.X * between.X) + (between.Y * between.Y));
            if (distance <= TargetTextureSize*0.9 && !DidHit)
            {
                game.ConfirmedHit();
                DidHit = true;
            }
            if (ticks % Rate == 0)
            {
                Random r = new Random();
                TargetTextureSize = r.Next(100, 250);
                _targetPosition = new Point(r.Next(0, screenSize.Width-TargetTextureSize/2), r.Next(0,screenSize.Height-TargetTextureSize/2));
                DidHit = false;
                if ( Rate > 40 && Rate <= 80)
                {
                    Rate -= 2;
                }
                else if( Rate <= 40 && Rate > 20)
                {
                    Rate -= 1;
                }
                else if( Rate > 80 && Rate <= 200)
                {
                    Rate -= 10;
                }
                Refresh();
            }
            if(ticks % 7200 == 0)
            {
                timer1.Stop();
                if(game.score > game.BestScore)
                {
                    game.BestScore = game.score;
                }
                game.LastResult = game.score;
                Rate = 50;
                game.score = 0;
                game.EndGame();
                ticks = 0;
            }
        }
    }
}