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
    public partial class FinishScreen : UserControl
    {
        private Game game;
        private Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;

        public FinishScreen()
        {
            InitializeComponent();
        }
        public void Configure(Game game)
        {
            this.game = game;
        }

        private void FinishScreen_Paint(object sender, PaintEventArgs e)
        {
            DrawText(e, Color.White, $"ваш результат : {game.LastResult}", 30);
            DrawText(e, Color.White, $"лучший результат : {game.BestScore}", 30, 0 , 100);
            DrawText(e, Color.Gray, "НАЖМИТЕ ЛЕВУЮ КНОПКУ МЫШИ, ЧТОБЫ НАЧАТЬ ЗАНОВО", 30, 0, 200);
        }
        protected void DrawText(PaintEventArgs e, Color color, string text, int fontSize, int shiftXFromCenter = 0,
    int shiftYFromCenter = 0,
    StringFormat stringFormat = null, FontStyle fontStyle = FontStyle.Regular)
        {
            var drawFont = new Font("Arial", fontSize, fontStyle);
            var brush = new SolidBrush(color);
            var widthCenter =  screenSize.Width / 2 + shiftXFromCenter;
            var heightCenter = screenSize.Height / 2 + shiftYFromCenter;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.DrawString(text, drawFont, brush, widthCenter, heightCenter,
                stringFormat ?? new StringFormat
                { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
        }

        private void FinishScreen_MouseClick(object sender, MouseEventArgs e)
        {
            game.Start();
        }
    }
}
