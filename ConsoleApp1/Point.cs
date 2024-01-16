using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        private double x;
         public double GetX
         {
            get { return x = GetX; }
         }
        public double SetX
        {
            set { SetX=x; }
        }
       
        private double y;
        public double GetY
        {
            get { return y=GetY; }
        }
        public double SetY
        {
            set { SetY = y; }
        }

        public static int count;

        public Point(double x,double y)
        {
            this.y = y;
            this.x = x;
            count++;
        }
        public Point()
        {
            y = 1.0;
            x = 2.0;
            count++;

        }

        static Point()
        {
            count = 0;
        }

        public void Print()
        {
            Console.WriteLine( $"x:{x}||y:{y}\n{count}");
        }

        public static double LenghtPoints(double x1, double y1, double x2, double y2)
        {
            
           return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        
    }
}
