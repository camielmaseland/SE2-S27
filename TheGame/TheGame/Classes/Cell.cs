using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheGame
{
    class Cell
    {
        public Point Index { get; set; }
        public Point Position { get; set; }
        public CellType Type { get; set; }

        public Cell(Point index, Point position, CellType type)
        {
            index = index;
            position = position;
            Type = type;
        }

        public void draw(Graphics g)
        {

        }

        public enum CellType
        {
            Normal, Goal, Wall
        }

    }
}
