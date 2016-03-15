using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheGame
{
    class World
    {
        public readonly Boolean gameWon;
        public readonly Boolean gameOver;

        private Map map;
        private Enemy enemy;
        private Player player;

        public Boolean GameWon
        {
            get { return gameWon; }
        }

        public Boolean GameOver
        {
            get { return gameOver; }
        }

        public World(Boolean gameWon, Boolean gameOver)
        {
            this.gameWon = gameWon;
            this.gameOver = gameOver;
        }

        public void update()
        {

        }

        public void draw(Graphics g)
        {

        }
    }

}
