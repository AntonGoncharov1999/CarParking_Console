using CarParking.classes;


namespace CarParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking("Главная парковка", "секция 0");
            while (true) {
                Console.WriteLine("\nГлавное меню:");
                Console.WriteLine("1. Добавить автомобиль");
                Console.WriteLine("2. заправить автомобиль");
                Console.WriteLine("3. Посмотреть список автомобилей");
                Console.WriteLine("4. Выход");

                int choice = ValidInput("Выбор действия: ", 1, 4);

                static int ValidInput(string mes,int min, int max)
                {
                    int result;

                    while (true)
                    {
                        Console.Write(mes);
                        if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                        {
                            return result;
                        }
                        else
                        {
                            Console.WriteLine($"действие не найдено : введите число от {min} до {max}");
                        }
                    }
                    
                }

                switch (choice)
                {
                    case 1: {
                            Console.WriteLine(" Добавление автомобиля");
                            Console.Write("Введите марку: ");

                            string name_car = Console.ReadLine();
                            while (string.IsNullOrWhiteSpace(name_car))
                            {
                                Console.WriteLine("марка не может быть пустой. Введите снова: ");
                                name_car = Console.ReadLine();
                            }

                            int tankСondition_car = ValidInput("в баке: ",0,100);
                            bool canRefill = tankСondition_car < 100;

                            Volvo volvo = new Volvo(name_car, tankСondition_car, "двигатель заведен", canRefill);
                            parking.AddCar(volvo);

                            Console.WriteLine("Автомобиль добавлен\n");
                            break;
                        }
                    case 2: {
                            var canRefillCars = parking.CanRefillCar();

                            if (canRefillCars.Count == 0)
                            {
                                Console.WriteLine("В автопарке все автомобили заправлены");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nСписок Автомобилей для заправки:");
                                for (int i = 0;  i < canRefillCars.Count; i++)
                                {
                                    Console.WriteLine(canRefillCars[i].Name);
                                }
                                int chois_feed = ValidInput("выберите номер автомобиля",1,canRefillCars.Count);

                                parking.RefillCar(parking, canRefillCars[chois_feed - 1]);

                                Console.WriteLine("Автомобиль заправлен");
                                break;
                            }
                        }
                    case 3: {
                            if(parking.cars.Count == 0)
                            {
                                Console.WriteLine("В автопарке нет автомобилей\n");
                            }
                            else
                            {
                                Console.WriteLine("\nСписок Автомобилей: ");
                                parking.ViewListCar(parking);
                            }
                            break;
                        }
                    case 4:{
                            Console.WriteLine("Выход из программы...");
                            return;
                        }

                }
            }
        }
    }
}
