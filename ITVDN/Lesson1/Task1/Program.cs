using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Addres
    {
        private string index;               //Создаем поле (переменную)
        public string Index                 // Создаем метод
        {
            get { return index; }           // Задаем правило для возвращаемых данных
            set { index = value; }          // Задаем правило для входящих данных
        }
        public string Country { get; set; }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private string house;
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        private string apartment;
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }


    class Program
    {
        static void Main()
        {
            Addres addres = new Addres();  // Coздание экземпляра класса

            addres.Index = " 230001";
            addres.Country = "Республика Беларусь";
            addres.City = "Гродно";
            addres.Street = "Окульная";
            addres.House = " 21";
            addres.Apartment = " 75";

            Console.WriteLine(addres.Country);
            Console.Write(addres.City);
            Console.WriteLine(addres.Index);
            Console.Write(addres.Street);
            Console.Write(addres.House);
            Console.Write(addres.Apartment);
            Console.ReadKey();

        }
    }
}
