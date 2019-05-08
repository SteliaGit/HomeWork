using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNamespace
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длинну масива - ");
            int n = Convert.ToInt32(Console.ReadLine());

            //Arr mass = new Arr(n);

            Sort sor1 = new Sort(n);
            Sort sor2 = new Sort(4);
            sor1.write();
            sor2.write();
            Console.ReadKey();
        }
    }
}
