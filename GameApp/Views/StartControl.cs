using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameApp.models;

namespace GameApp.Views
{
    public partial class StartControl : UserControl
    {
        private Game? game;
        public StartControl()
        {
            InitializeComponent();
        }
        public void Configure(Game game)
        {
            this.game = game;
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Start();
        }
    }
}