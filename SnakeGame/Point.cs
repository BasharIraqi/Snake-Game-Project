using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    struct Point
    {
        public int Left { get; set; }
        public int Top { get; set; }

        public Point(int left, int top)
        {
            Left = left;
            Top = top;
        }
    }
}
