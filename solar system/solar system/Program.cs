using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solar_system
{
    class Program
    {
        static void create2(IPlan pl)
            {
            pl.Create();
            }

        static void Main(string[] args)
        {
            int choice;

            try
            {
                do
                {
                    Console.WriteLine("Сделайте выбор:");
                    Console.WriteLine("1 - Создать Планету");
                    Console.WriteLine("2 - Создать Землю");
                    Console.WriteLine("3 - Выход из программы");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                create2(new Planet());
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                create2(new Earth());
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Программа завершила свою работу, сейчас будет произведен выход. Hажмите Enter для продожения");
                                Console.ReadKey();
                                break;
                            }
                    }

                    Console.Clear();
                }
                while (choice != 3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }

        
            

    }
}
