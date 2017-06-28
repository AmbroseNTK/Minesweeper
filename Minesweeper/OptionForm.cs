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
    public partial class OptionForm : DevExpress.XtraEditors.XtraForm
    {
        private Form1 myGame;

        public Form1 MyGame { get => myGame; set => myGame = value; }

        public OptionForm()
        {
            InitializeComponent();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            MyGame.BoardWidth = (int)(numWidth.Value);
            MyGame.BoardHeight = (int)(numHeight.Value);
            MyGame.PercentMines = (int)(selectMode.Value);
            MyGame.createNewGame();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            numWidth.Value = MyGame.BoardWidth;
            numHeight.Value = MyGame.BoardHeight;
        }
    }
}
