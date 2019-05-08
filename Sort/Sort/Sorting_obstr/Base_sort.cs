using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_obstr
{
     abstract class Base_sort
    {
        protected string inputt;
        protected int input;
        public Int32 ins;
        protected int temp;                     // Add fields
        protected Int16 inp;
        protected int[] arr;
                         
        public Base_sort(int input)                //Add constructor
        {
            this.arr = new int[input];
            Add_array();
            Init();
        }
        public Base_sort(Int16 inp)
        {
            this.inp =  inp;
        }
        public Base_sort(string inputt)
        {
            this.inputt = inputt;
            Chek();     

        }
        protected virtual void Chek()
        {
           foreach (var item in inputt)
            {
               
                if ((item > '0') && (item < '9'))
                {
                    ins++;
                }
            }
         }


        private void Add_array()
        {
           
            Console.WriteLine("Не отсортированный массив");
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                
            }
            arr = arr.Distinct().ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        protected virtual void Init()
        {
            Console.WriteLine("Массив после сортировки - ");
        }
    }
}
