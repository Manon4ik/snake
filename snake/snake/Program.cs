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

            Point p1 = new Point(1,3,'*');
            p1.Draw();


            Point p2 = new Point(2,4,'#');
            p2.Draw();

            HorizontallLine line = new HorizontallLine(7, 14, 10, '#');
            line.DrowHorLine();

            VerticalLine lineVert = new VerticalLine(2, 7, 3, '$');
            lineVert.DrowVertLine();
            
            Console.ReadLine();
        }

    }
}
