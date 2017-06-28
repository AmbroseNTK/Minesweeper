using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameOver : DevExpress.XtraEditors.XtraForm
    {
        private Form1 myGame;
        public GameOver()
        {
            InitializeComponent();
        }

        public Form1 MyGame { get => myGame; set => myGame = value; }

        private void btPlay_Click(object sender, EventArgs e)
        {
            this.Close();
            MyGame.createNewGame();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
