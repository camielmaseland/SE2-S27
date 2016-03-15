using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheGame
{
    class Enemy
    {
        public Point position { get; set; }
        public int hitPoint { get; set; }

        public Enemy(Point position, int hitPoints)
        {
            position = position;
            hitPoints = hitPoints;
        }

        public void update()
        {

        }

        public void draw(Graphics g)
        {

        }

        public void attack(Player player)
        {

        }
    }
}
