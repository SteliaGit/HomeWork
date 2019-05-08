using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNamespace
{
    class Arr
    {        
        protected int[] array;
        public Arr (int input)
        {
            array =  new int[input];
            init();
        }

         void init()
        {
            Random rand = new Random();
            Console.WriteLine("Массив до сортировки - ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine($"{ array[i]}");
            }
        }

    }
}
