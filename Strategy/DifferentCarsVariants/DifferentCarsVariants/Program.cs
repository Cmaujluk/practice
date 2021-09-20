using DifferentCarsVariants.Cars;
using DifferentCarsVariants.Drive;
using DifferentCarsVariants.Movement;
using DifferentCarsVariants.Sound;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DifferentCarsVariants
{
    class Program
    {
        private static void Main()
        {
            InitCars(out List<CarBase> cars);
            DisplayCarsInfo(cars);

            DisplayVariableCar();  //example of variable cars
        }

        private static void DisplayVariableCar()
        {
            Console.WriteLine();
            var constructionCar = new CarBase(new NoMove(), new NoSound(), new WithoutDriver()) { Name = "Test Car" };

            Console.WriteLine($"{constructionCar.Name} info:");
            constructionCar.Simulate();
            Console.WriteLine();

            constructionCar.SetMovement(new Fly());
            constructionCar.SetDriving(new AIDriving());
            constructionCar.SetSound(new SimulationSound());

            Console.WriteLine($"{constructionCar.Name} info:");
            constructionCar.Simulate();
        }

        private static void DisplayCarsInfo(List<CarBase> cars)
        {
            var last = cars.Last();

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Name} info:");
                car.Simulate();
                if (car != last) Console.WriteLine();
            }
        }

        private static void InitCars(out List<CarBase> cars)
        {
            cars = new List<CarBase>();

            var flyingCar = new FlyingCar("T-4000");
            cars.Add(flyingCar);

            var teslaCar = new ElectricCar("Tesla");
            cars.Add(teslaCar);
        }
    }
}
