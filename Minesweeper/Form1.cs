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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private ChessBoard board;
        private int boardWidth;
        private int boardHeight;
        private int percentMines;

        public int BoardWidth { get => boardWidth; set => boardWidth = value; }
        public int BoardHeight { get => boardHeight; set => boardHeight = value; }
        public int PercentMines { get => percentMines; set => percentMines = value; }
        private DateTime time;
        public Form1()
        {
            InitializeComponent();
            BoardWidth = 10;
            BoardHeight = 10;
            Cell.MyGame = this;
            createNewGame();
        }
        public void createNewGame()
        {
            if (board != null)
                Controls.Remove(board);
            board = new ChessBoard(BoardWidth, BoardHeight);
            board.Location = new Point(0, 0);
            board.Dock = DockStyle.Fill;
            board.BringToFront();
            if(!Controls.Contains(board))
                Controls.Add(board);
            time = new DateTime();
            timer1.Start();
        }
        public void gameOver()
        {
            timer1.Stop();
            MessageBox.Show("GAME OVER");
        }
        public void setFlag()
        {

        }
        public void unsetFlag()
        {

        }
        public void resizeWindows(int width, int height)
        {
            Cell temp = new Cell();
            this.Size = new Size(width * temp.Size.Width+70, height * temp.Size.Height+100);
        }

        private void btNewGame_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            createNewGame();
        }

        private void btOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OptionForm option = new OptionForm();
            option.MyGame = this;
            option.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            lbTime.Caption = "Time: " + time.Second.ToString() + "s";
            if (time.Minute > 0)
            {
                lbTime.Caption = "Time: " + time.Minute.ToString() + "m" + time.Second.ToString() + "s";
            }
            if (time.Hour > 0)
            {
                lbTime.Caption = "Time: " + time.Hour.ToString() + "h" + time.Minute.ToString() + "m" + time.Second.ToString() + "s";
            }
            
        }
    }
}
