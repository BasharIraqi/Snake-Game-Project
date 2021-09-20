using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    abstract class BaseShape
    {
        public Point LeftTop { get; set; }
        public char ch{ get; set; }

        public abstract void PrintShape();

        protected BaseShape(Point leftTop ,char ch)
        {
            LeftTop = leftTop;
            this.ch = ch;
        }

    }
}
