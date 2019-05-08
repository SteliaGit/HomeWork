using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("****** Строим треугольник ******");
            Console.WriteLine("Введите пожалуйста первую сторону");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите пожалуйста вторую сторону");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Периметр равен = {rectangle.Perimeter}");
            Console.WriteLine($"Площадь ровна = {rectangle.Area}");

            Console.ReadKey();
        }
    }
}
