using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoSnakeGame.Model
{
    public class SnakePosition
    {
        public int X { get; set; }
        public int y { get; set; }
        public SnakePosition(int X,int Y)
        {
            this.X = X;
            this.y = Y;
        }


    }
}
