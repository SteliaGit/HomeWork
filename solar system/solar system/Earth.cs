using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace solar_system
{
    class Earth : IPlan
    {

        public string Name { get; set; }
        public int Number
        {
            set
            {
                if (value < 123)
                {
                    Console.WriteLine(" должен быть больше 123 size");
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
            Console.WriteLine("Создаем ЗЕМЛЮ");
            Name = "ЗЕМЛЯ";
            Console.WriteLine("Введите Размер");
            int number = 0;
            Number = number;
            int.TryParse(Console.ReadLine(), out number);


            Console.WriteLine(Name + " создана");
            Console.WriteLine("Размер - " + number);
        }


    }
}