using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double R =double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки А");
            double X=double.Parse(Console.ReadLine());
            double Y=double.Parse(Console.ReadLine());

            double Length= circle.GetLength(R);
            double Squre = circle.GetSqure(R);
            Console.WriteLine ($"Длина окружности ={Length}, Площадь круга ={Squre}");
            circle.GetKoordinat(R,X,Y);
            Console.ReadLine();
        }
    }
}
