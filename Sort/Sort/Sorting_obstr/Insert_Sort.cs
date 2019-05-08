using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_obstr
{
    class Insert_Sort : Base_sort
    {
        public Insert_Sort(int input) : base(input)
        { }

        protected override void Init()
        {
            base.Init();
            int index;
            for (int i = 0; i < arr.Length; ++i)
            {
                index = i;
                temp = arr[i];
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[j] < temp)
                    {
                        index = j;
                        temp = arr[j];
                    }
                }
                arr[index] = arr[i];
                arr[i] = temp;
            
            Console.WriteLine($"{ arr[i]}");
            }

        }
    }
}
