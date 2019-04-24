using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solar_system
{
    public class Planet : IPlan
    {   
      
        public string Name { get; set; }
        public int Number
        {
            set
            {
                if (value < 2)
                {
                    Console.WriteLine(" должен быть больше 2");
                }
                else
                {
                    {
                        Number = value;
                    }
                }
            }
            get { return Number; }               
        }
       
        public void Create()
        {
            Console.WriteLine("Введите имя планеты");
            Name = Console.ReadLine();
            Console.WriteLine("Введите порядок");
            int number = 0;
            Number = number;
            int.TryParse(Console.ReadLine(), out number);
         


            Console.Write("Планета создана - " + Name);
            Console.Write("Номер - " + Number);
        }


    }
}
