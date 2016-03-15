using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheGame
{
    class Player
    {
        public Point position { get; set; }
        public Boolean powerUp { get; set; }
        public int hitPoints { get; set; }

        public Player(Point positionPoint, Boolean powerUp, int hitPoints)
        {

        }

        public void update()
        {

        }

        public void draw(Graphics g)
        {

        }

        public void interaction(int keyCode)
        {

        }

        public enum Action
        {
            NoAction, MoveUp, MoveRight, MoveDown, MoveLeft, PerformAction
        }

    }
}
