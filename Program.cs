using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // чете от конзолата страна и височина на триъгълник и пресмята неговото лице. 
            // формулата за лице на триъгълник: area = a * h / 2. 
            // Закръглете резултата до 2 знака след десетичната точка използвайки Math.Round(area, 2).

            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = Math.Round(a * h / 2, 2);

            Console.WriteLine("Triangle area= " + area);


        }
    }
}
