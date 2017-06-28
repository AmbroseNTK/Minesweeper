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
    public partial class WinnerForm : DevExpress.XtraEditors.XtraForm
    {
        private Form1 myGame;
        public WinnerForm()
        {
            InitializeComponent();
        }

        public Form1 MyGame { get => myGame; set => myGame = value; }

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            DateTime time = MyGame.getTime();
            lbTime.Text = "Time: " + time.Hour + ":" + time.Minute + ":" + time.Second;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            MyGame.createNewGame();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
