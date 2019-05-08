using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNamespace
{
    class Sort : Arr
    {
      
        public Sort (int input) : base(input)
        {

        }

        public void write()
        {
            Console.WriteLine(this.array);
        }
        
        
       public void sort()   
        {
            Console.WriteLine("Массив после сортировки - ");
            var arr = this.array;
            int t;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }                    
                }
                Console.WriteLine($"{ array[i]}");
            }
            
        }
       
    }
}
