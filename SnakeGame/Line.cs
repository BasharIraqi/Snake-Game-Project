using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Line : BaseShape
    {
        public Line(Point leftTop, char ch) : base(leftTop, ch)
        {
        }

        public override void PrintShape()
        {
            int rnd = new Random().Next(2, 10);
            for (int i = 0; i < rnd; i++)
            {
                Console.Write("=");
                Program.isUsed[i,0] = true;
            }
        }


    }
}
