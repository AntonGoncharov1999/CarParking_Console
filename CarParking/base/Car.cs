using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    class Car : ICar
    {
        public string Name { get; set; }
        public int Tank—ondition { get; set; }
        public string Launch { get; set; }
        public bool CanRefill { get; set; }

        public Car (string name, int tank—ondition, string launch, bool canRefill)
        {
            Name = name;
            Tank—ondition = tank—ondition;
            Launch = launch;
            CanRefill = canRefill;
        }
        
        public void CarLaunch(ICar car)
        {
            Console.WriteLine(car.Launch);
        }
    }
}
