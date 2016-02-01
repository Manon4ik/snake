using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(100, 45);

            //отрисовка рамочки
            HorizontallLine upLine = new HorizontallLine(0, 78, 0, '+');
            HorizontallLine downLine = new HorizontallLine(0, 78, 24, '+');
            VerticalLine lefLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            lefLine.Drow();
            rightLine.Drow();

            //отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while(true)
            {
                if (snake.Eat(food) )
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                System.Threading.Thread.Sleep(350);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
                
            }

            //Console.ReadLine();
        }

    }
}
