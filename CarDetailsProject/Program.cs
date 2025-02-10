using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDetailsProject
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarMake { get; set; } // Manufacturing company name
        public int ModelNo { get; set; }
        public int BasePrice { get; set; }

        // Override ToString method
        public override string ToString()
        {
            return $"CarId: {CarId}, CarName: {CarName}, CarMake: {CarMake}, ModelNo: {ModelNo}, BasePrice: {BasePrice:C}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Car Showroom");

            // Create a list of cars
            List<Car> cars = new List<Car>
            {
                new Car { CarId = 1, CarName = "Model S", CarMake = "Tesla", ModelNo = 2021, BasePrice = 80000 },
                new Car { CarId = 2, CarName = "Civic", CarMake = "Honda", ModelNo = 2022, BasePrice = 25000 },
                new Car { CarId = 3, CarName = "Corolla", CarMake = "Toyota", ModelNo = 2021, BasePrice = 22000 },
                new Car { CarId = 4, CarName = "Mustang", CarMake = "Ford", ModelNo = 2023, BasePrice = 55000 },
                new Car { CarId = 5, CarName = "Model 3", CarMake = "Tesla", ModelNo = 2023, BasePrice = 40000 }
            };

            // Display car details
            Console.WriteLine("\nList of Cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            // (i) Find car with the maximum base price
            var maxPriceCar = cars.OrderByDescending(car => car.BasePrice).FirstOrDefault();
            Console.WriteLine("\nCar with the maximum base price:");
            Console.WriteLine(maxPriceCar);

            // (ii) Count cars by manufacturer
            var carsByManufacturer = cars.GroupBy(car => car.CarMake)
                                         .Select(group => new { Manufacturer = group.Key, Count = group.Count() });

            Console.WriteLine("\nCount of cars from each manufacturer:");
            foreach (var item in carsByManufacturer)
            {
                Console.WriteLine($"Manufacturer: {item.Manufacturer}, Count: {item.Count}");
            }
        }
    }
}
