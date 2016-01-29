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
            upLine.DrowHorLine();
            downLine.DrowHorLine();
            lefLine.DrowVertLine();
            rightLine.DrowVertLine();


            Console.ReadLine();
        }

    }
}
