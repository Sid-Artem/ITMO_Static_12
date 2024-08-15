using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public static class circle
    {
        static public double GetLength(double r)
        {
            return 2*Math.PI*r;

        }

        static public double GetSqure(double r)
        {
            return Math.PI * r*r;

        }
        static public void GetKoordinat(double r, double x, double y)
        {

            if ((x)*(x) + (y) * (y) <= r * r)
                Console.WriteLine("Точка принадлежит окружности");
           else Console.WriteLine ("Точка не принадлежит окружности");
            
        }
    }
}
