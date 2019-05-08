using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_obstr
{
    class Buble_Sort : Base_sort
    {
      public Buble_Sort (int input) : base (input)
        { }



        protected override void Init()
        {
            base.Init();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine($"{ arr[i]}");
            }
        }


    }
}
