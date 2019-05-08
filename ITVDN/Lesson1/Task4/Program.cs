using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));
            Console.Write($"{figure.Type}, P = " );

            figure.PerimeterCalculator();

          
            Console.ReadKey();
        }
    }
}
