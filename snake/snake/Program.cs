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

            List<int> numList = new List<int>();
           {
                numList.Add(0);
                numList.Add(1);

           }
            foreach (int x in numList)
            {
                Console.Write(x);
            }


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            //foreach (int i in pList)
            //{
            //    Console.Write(i);
            //}
            
            Console.ReadLine();
        }

    }
}
