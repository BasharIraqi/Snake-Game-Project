using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Traingle : BaseShape
    {
        public Traingle(Point leftTop, char ch) : base(leftTop, ch)
        {
        }

        public override void PrintShape()
        {
            int rnd = new Random().Next(2,9);

            for (int i = 0; i < rnd; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("#");
                    Program.isUsed[i, j] = true;
                }
                Console.WriteLine();
            }
        }

    }
}
