namespace CarParking
{
    internal class Parking
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<ICar> cars { get; set; } = new List<ICar>();

        public Parking(string name, string location) { 
            Name = name;
            Location = location;
        }

        public void AddCar(ICar car)
        {
            cars.Add(car);
        }

        public void RefillCar(Parking parking, ICar car)
        {
            car.TankÑondition += 10;
            if (car.TankÑondition >= 100)
            {
                car.CanRefill = false;
            }
        }

        public void ViewListCar(Parking parcing)
        {
            Console.WriteLine($"íà ïàğêîâêå {parcing.Name} ñîäåğæàòñÿ {parcing.cars.Count} àâòîìîáèëåé:");
            for (int i = 0; i < cars.Count; i++) {
                Console.WriteLine($"{i+1} - {parcing.cars[i].Name} = {parcing.cars[i].TankÑondition} % òîïëèâà");
            }
        }

        public List<ICar> CanRefillCar()
        {
            return cars.Where(a => a.CanRefill).ToList();
        }
    }
}