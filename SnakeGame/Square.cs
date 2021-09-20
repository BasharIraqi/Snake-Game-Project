using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Square : BaseShape
    {
        public Square(Point leftTop, char ch) : base(leftTop, ch)
        {

        }

        public override void PrintShape()
        {
            int rnd = new Random().Next(3,10);

            for (int i = 0; i < rnd; i++)
            {
                for (int j = 0; j < rnd; j++)
                {
                    Console.Write("$");
                    Program.isUsed[i,j] = true;
                }
                Console.WriteLine();
            }
        }


    }
}
