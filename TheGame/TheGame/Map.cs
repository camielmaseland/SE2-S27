using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheGame
{
    class Map
    {
        public Size mapSize { get; set; }
        public Size cellSize { get; set; }
        public Size cellCount { get; set; }
        public Point goalPosition { get; set; }

        private List<Cell> cells;

        public Map(Size mapSize, Size cellSize, Size cellCount, Point goalPosition)
        {
            
        }

        public void draw(Graphics g)
        {

        }
    }
}
