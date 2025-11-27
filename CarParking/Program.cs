using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking("Главная парковка", "секция 0");
            while (true) {
                Console.WriteLine("\nГлавное меню:");
                Console.WriteLine("1. Добавить льва");
                Console.WriteLine("2. Покормить животное");
                Console.WriteLine("3. Посмотреть список животных");
                Console.WriteLine("4. Выход");
            }
        }
    }
}
