using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public enum CellTypes
    {
        UNSELECT,
        MINE,
        FLAG,
        EMPTY,
        NUMERIC
    }
    public partial class Cell : UserControl
    {
        private static Form1 myGame;
        private CellTypes cellTypeBehavior;
        private CellTypes cellType;
        private int number;
        private Point index;
        public Cell()
        {
            InitializeComponent();
            setCellTypeBehavior(CellTypes.UNSELECT);
            CellType = CellTypes.EMPTY;
        }
        public Cell(Point index, Point position, CellTypes cellType)
        {
            InitializeComponent();
            setCellTypeBehavior(CellTypes.UNSELECT);
            CellType = cellType;
            this.Location = position;
            Index = index;
           
        }
        public void setCellTypeBehavior(CellTypes cellType)
        {
                CellTypeBehavior = cellType;
            switch (cellType)
            {
                case CellTypes.UNSELECT:
                    this.Enabled = true;
                    lbNum.Hide();
                    pictureBox1.Hide();
                    break;
                case CellTypes.EMPTY:
                    this.Enabled = false;
                    this.BackColor = Color.White;
                    lbNum.Hide();
                    pictureBox1.Hide();
                    break;
                case CellTypes.FLAG:
                    this.Enabled = true;
                    lbNum.Hide();
                    pictureBox1.Show();
                    pictureBox1.Load(Application.StartupPath + "\\flag.png");
                    break;
                case CellTypes.MINE:
                    this.Enabled = false;
                    lbNum.Hide();
                    BackColor = Color.Red;
                    pictureBox1.Show();
                    pictureBox1.Load(Application.StartupPath + "\\mine.png");
                    break;
                case CellTypes.NUMERIC:
                    this.Enabled = false;
                    lbNum.Show();
                    pictureBox1.Hide();
                    BackColor = Color.White;
                    break;
            }
            
        }
        public void setNumber(int num)
        {
            Number = num;
            lbNum.Text = Number.ToString();
            switch (Number)
            {
                case 1:
                    lbNum.ForeColor = Color.DodgerBlue;
                    break;
                case 2:
                    lbNum.ForeColor = Color.Navy;
                    break;
                case 3:
                    lbNum.ForeColor = Color.ForestGreen;
                    break;
                case 4:
                    lbNum.ForeColor = Color.Gold;
                    break;
                case 5:
                    lbNum.ForeColor = Color.Orange;
                    break;
                case 6:
                    lbNum.ForeColor = Color.OrangeRed;
                    break;
                case 7:
                    lbNum.ForeColor = Color.Red;
                    break;
                case 8:
                    lbNum.ForeColor = Color.DarkRed;
                    break;
            }
        }
        public int Number { get => number; set => number = value; }
        public static Form1 MyGame { get => myGame; set => myGame = value; }
        public CellTypes CellTypeBehavior { get => cellTypeBehavior; set => cellTypeBehavior = value; }
        public CellTypes CellType { get => cellType; set => cellType = value; }
        public Point Index { get => index; set => index = value; }

        private void lbNum_MouseClick(object sender, MouseEventArgs e)
        {
            Cell_MouseClick(sender, e);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Cell_MouseClick(sender, e);
        }
        private void Cell_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(CellTypeBehavior==CellTypes.UNSELECT)
                {
                    setCellTypeBehavior(CellTypes.FLAG);
                    MyGame.setFlag();
                }
                else if (cellTypeBehavior == CellTypes.FLAG)
                {
                    setCellTypeBehavior(CellTypes.UNSELECT);
                    MyGame.unsetFlag();
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                MyGame.setFirstClick(this.index);
                if (cellTypeBehavior == CellTypes.UNSELECT && (cellType == CellTypes.EMPTY||cellType==CellTypes.NUMERIC))
                {
                    setCellTypeBehavior(cellType);
                }
                else if (CellType == CellTypes.MINE && CellTypeBehavior == CellTypes.UNSELECT)
                {
                    setCellTypeBehavior(cellType);
                    MyGame.gameOver();
                }
            }
        }

        private void Cell_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Cell_MouseLeave(object sender, EventArgs e)
        {
           
        }
    }
}
