using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Rectangle : BaseShape
    {
        public Rectangle(Point leftTop, char ch) : base(leftTop, ch)
        {
        }

        public override void PrintShape()
        {
            int rnd1 = new Random().Next(2,10);
            int rnd2 = new Random().Next(2,10);
            for (int i = 0; i < rnd1; i++)
            {
                for (int j = 0; j <rnd2; j++)
                {
                    Console.Write("@");
                    Program.isUsed[i,j] = true;
                }
                Console.WriteLine();
            }
        }

    }
}
