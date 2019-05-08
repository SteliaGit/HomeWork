using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_obstr
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var inpu = 0;
            var lim = 0;
            do
            {
                Console.WriteLine("Выбор сортировки:");
                Console.WriteLine("1 - Пузырьковая сортировка");
                Console.WriteLine("2 - Сортировка вставки");
                Console.WriteLine("3 - Сортировка выбором");
                Console.WriteLine("4 - Выход из программы");

                Check chek = new Check(Console.ReadLine());
                Base_sort base_ = null;
                lim = chek.ins;
                
                switch (lim)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите количество элементов массива:");
                            inpu = Convert.ToInt32(Console.ReadLine());
                            base_ = new Buble_Sort(inpu);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите количество элементов массива:");
                            inpu = Convert.ToInt32(Console.ReadLine());
                            base_ = new Insert_Sort(inpu);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("----- Сортировка выбором в данный момент не доступна------");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Программа завершила свою работу, сейчас будет произведен выход");
                            break;
                        }
                    default :
                        {
                            Console.WriteLine($"Введите правильное значение");
                            break;
                        }
                       

                }
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadKey();
                Console.Clear();


            } while (lim != 4);
        }
    }
}
