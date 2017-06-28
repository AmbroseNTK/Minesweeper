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
        private int percentNumMine;
        private Dictionary<Point, Cell> cellMap;

        public ChessBoard()
        {
            InitializeComponent();
        }
        public ChessBoard(int width,int height,int percentMine)
        {
            BoardWidth = width;
            BoardHeight = height;
            PercentNumMine = percentMine;
            numMine = (int)((float)PercentNumMine * 0.01f * (float)BoardWidth * (float)BoardHeight)+1;
            Cell.MyGame.setNumMine(numMine);
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
                    cellMap.Add(index, new Cell(index, pos, CellTypes.EMPTY));
                    Controls.Add(cellMap[index]);
                    pos.X += tSize.Width;
                }
                pos.X = 0;
                pos.Y += tSize.Height;
               
            }
            Cell.MyGame.resizeWindows(BoardWidth, BoardHeight);
        }
        public void createMines(Point firstClick)
        {
            List<Point> firstArea = new List<Point>();
            firstArea = getCellAround(firstClick);
            List<Point> anotherPoint = cellMap.Keys.ToList<Point>();
            for (int i = 0; i < firstArea.Count; i++)
                if(anotherPoint.Contains(firstArea[i]))
                    anotherPoint.Remove(firstArea[i]);
            Random rand = new Random();
            int count = NumMine;
            while (count > 0)
            {
                int r = rand.Next(0, anotherPoint.Count);
                CellMap[anotherPoint[r]].CellType =CellTypes.MINE;
                anotherPoint.RemoveAt(r);
                count--;
            }
            for (int i = 0; i < firstArea.Count; i++)
                if (CellMap.Keys.Contains(firstArea[i]))
                    anotherPoint.Add(firstArea[i]);
            for(int i = 0; i < anotherPoint.Count; i++)
            {
                int c = 0;
                Point p0 = anotherPoint[i];
                List<Point> around = getCellAround(p0);
                for (int j = 0; j < around.Count; j++)
                {
                    if (CellMap.Keys.Contains(around[j])&&CellMap[around[j]].CellType == CellTypes.MINE)
                        c++;
                }
                if (c != 0)
                {
                    CellMap[anotherPoint[i]].CellType = CellTypes.NUMERIC;
                    CellMap[anotherPoint[i]].setNumber(c);
                }
                /*
                else
                {
                    CellMap[anotherPoint[i]].CellType =CellTypes.EMPTY;
                }*/
            }
        }
        public void open(Point mid)
        {
            if (cellMap.Keys.Contains(mid) && CellMap[mid].CellType == CellTypes.NUMERIC)
                cellMap[mid].setCellTypeBehavior(CellMap[mid].CellType);
            else if (CellMap.Keys.Contains(mid) && CellMap[mid].CellType != CellTypes.MINE)
            {
                if (CellMap[mid].CellType != CellMap[mid].CellTypeBehavior)
                {
                    CellMap[mid].setCellTypeBehavior(CellMap[mid].CellType);
                    open(new Point(mid.X, mid.Y + 1));
                    open(new Point(mid.X, mid.Y - 1));
                    open(new Point(mid.X + 1, mid.Y));
                    open(new Point(mid.X - 1, mid.Y));
                    open(new Point(mid.X + 1, mid.Y - 1));
                    open(new Point(mid.X + 1, mid.Y + 1));
                    open(new Point(mid.X - 1, mid.Y + 1));
                    open(new Point(mid.X - 1, mid.Y - 1));
                }
            }

        }
        public List<Point> getCellAround(Point p0)
        {
            List<Point> pointAround = new List<Point>();
            pointAround.Add(p0);
            pointAround.Add(new Point(p0.X + 1, p0.Y));
            pointAround.Add(new Point(p0.X + 1, p0.Y + 1));
            pointAround.Add(new Point(p0.X + 1, p0.Y - 1));
            pointAround.Add(new Point(p0.X, p0.Y + 1));
            pointAround.Add(new Point(p0.X, p0.Y - 1));
            pointAround.Add(new Point(p0.X - 1, p0.Y));
            pointAround.Add(new Point(p0.X - 1, p0.Y + 1));
            pointAround.Add(new Point(p0.X - 1, p0.Y - 1));
            return pointAround;
        }
        public int BoardWidth { get => boardWidth; set => boardWidth = value; }
        public int BoardHeight { get => boardHeight; set => boardHeight = value; }
        public Dictionary<Point, Cell> CellMap { get => cellMap; set => cellMap = value; }
        public int NumMine { get => numMine; set => numMine = value; }
        public int PercentNumMine { get => percentNumMine; set => percentNumMine = value; }
    }
}
