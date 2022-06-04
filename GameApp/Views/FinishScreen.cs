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
        public FinishScreen()
        {
            InitializeComponent();
        }
        public void Configure(Game game)
        {
            this.game = game;
            label1.Text = "ваш результат : "
        }
    }
}
