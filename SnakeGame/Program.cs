using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        public static int curLeft;
        public static int curTop;
        public static bool[,] isUsed;
        private static List<BaseShape> shapes;
        private static int shapesToPrint;
        private static int leftPointShape;
        private static int topPointShape;
        static void Main(string[] args)
        {
            shapesToPrint = 4;
            leftPointShape = new Random().Next(80);
            topPointShape = new Random().Next(25);
           
            Point point = new Point(leftPointShape,topPointShape);

            Line line = new Line(point, '=');
            Traingle triangle = new Traingle(point, '#');
            Square square = new Square(point, '$');
            Rectangle rectangle = new Rectangle(point,'@');
            
            SetConsole(80,25);

            shapes = new List<BaseShape>
            {
                line,triangle,square,rectangle
            };
 
            for (int i = 0; i < shapesToPrint; i++)
            {
                int rnd= new Random().Next(shapes.Count);
                
                shapes[rnd].PrintShape();
                
                Console.WriteLine();
            }

            while (true)
            {
                GetNextStep();
                Thread.Sleep(50);
            }
          
        }

        static void SetConsole(int width,int height)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width,height);
           
            curLeft = new Random().Next(width);
            curTop = new Random().Next(height);
            Console.SetCursorPosition(curLeft, curTop);
            isUsed = new bool[width,height];
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine('*');
            isUsed[width-1, height-1] = true;

        }

        static void GetNextStep()
        {
           ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    Move(curLeft,curTop-1);
                    break;
                case ConsoleKey.DownArrow:
                    Move(curLeft,curTop+1);
                    break;
                case ConsoleKey.RightArrow:
                    Move(curLeft+1,curTop);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(curLeft-1,curTop);
                    break;

            }

        }

        static void Move(int newLeft,int newTop)
        {
            if (newLeft <  Console.WindowWidth && newLeft>0 && newTop < Console.WindowHeight && newTop>0)
            {
                if (isUsed[newLeft - 1, newTop - 1] )
                {
                    shapesToPrint++;
                    Console.Clear();
                    Console.WriteLine("Failed try again");
                }
                else
                { 
                Console.SetCursorPosition(curLeft, curTop);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write('*');
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(newLeft, newTop);
                Console.Write('*');
                isUsed[newLeft-1, newTop-1] = true;
                curLeft = newLeft;
                curTop = newTop;
                }
            }
        }
    }
}
