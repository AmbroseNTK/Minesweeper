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
    public partial class ChessBoard : UserControl
    {
        private int boardWidth;
        private int boardHeight;
        private int numMine;
        private Dictionary<Point, Cell> cellMap;

        public ChessBoard()
        {
            InitializeComponent();
        }
        public ChessBoard(int width,int height)
        {
            BoardWidth = width;
            BoardHeight = height;
            CellMap = new Dictionary<Point, Cell>();
            createEmptyBoard();
        }
        public void createEmptyBoard()
        {
            Cell temp = new Cell();
            Size tSize = temp.Size;
            Point pos = new Point(0, 0);
            for (int i = 0; i < BoardHeight; i++)
            {
                for (int j = 0; j < BoardWidth; j++)
                {
                    Point index = new Point(i, j);
                    cellMap.Add(index, new Cell(pos, CellTypes.EMPTY));
                    Controls.Add(cellMap[index]);
                    pos.X += tSize.Width;
                }
                pos.X = 0;
                pos.Y += tSize.Height;
               
            }
            Cell.MyGame.resizeWindows(BoardWidth, BoardHeight);
        }
        public int BoardWidth { get => boardWidth; set => boardWidth = value; }
        public int BoardHeight { get => boardHeight; set => boardHeight = value; }
        public Dictionary<Point, Cell> CellMap { get => cellMap; set => cellMap = value; }
        public int NumMine { get => numMine; set => numMine = value; }
    }
}
