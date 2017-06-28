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
        WinnerForm winner;
        GameOver gameOverForm;
        private int boardWidth;
        private int boardHeight;
        private int percentMines;
        private int numMine;
        private int maxNumMine;
        private bool firstClick;
        public int BoardWidth { get => boardWidth; set => boardWidth = value; }
        public int BoardHeight { get => boardHeight; set => boardHeight = value; }
        public int PercentMines { get => percentMines; set => percentMines = value; }
        public int NumMine { get => numMine; set => numMine = value; }

        private DateTime time;
        public Form1()
        {
            InitializeComponent();
            BoardWidth = 10;
            BoardHeight = 10;
            percentMines = 20;
            Cell.MyGame = this;
            createNewGame();
        }
        public void createNewGame()
        {
            if (board != null)
                Controls.Remove(board);
            board = new ChessBoard(BoardWidth, BoardHeight,percentMines);
            board.Location = new Point(0, 0);
            board.Dock = DockStyle.Fill;
            board.BringToFront();
            if(!Controls.Contains(board))
                Controls.Add(board);
            firstClick = true;
            time = new DateTime();
            timer1.Start();
        }
        public void setNumMine(int num)
        {
            NumMine = num;
            maxNumMine = numMine;
            showNumMine();
        }
        public void gameOver()
        {
            timer1.Stop();
            firstClick = true;
            gameOverForm = new GameOver();
            gameOverForm.MyGame = this;
            gameOverForm.ShowDialog();
        }
        public void setFlag()
        {
            if (numMine > 0)
                numMine--;
            showNumMine();
        }
        public void unsetFlag()
        {
            if(numMine<maxNumMine)
                numMine++;
            showNumMine();
        }
        public void setFirstClick(Point first)
        {
            if (firstClick)
            {
                board.createMines(first);
                firstClick = false;
            }
            board.open(first);
            if (board.checkWinner())
                setWinner();
        }
        private void showNumMine()
        {
            lbMine.Caption = "Mines: " + numMine.ToString();
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
            option.ShowDialog();
        }
        public void setWinner()
        {
            winner = new WinnerForm();
            winner.MyGame = this;
            winner.ShowDialog();
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
        public DateTime getTime()
        {
            return time;
        }
    }
}
