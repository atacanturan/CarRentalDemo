using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCarGetAll();
            //AddCar();
            //UpdateCar();

        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 2003,
                CarName = "208 Model 2020",
                BrandId = 1004,
                ColorId = 2,
                DailyPrice = 200,
                Description = "Firma A",
                ModelYear = 2013
            };
            var result = carManager.Update(car);
            Console.WriteLine(result.Message);
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarName = "208",
                BrandId = 1004,
                ColorId = 1002,
                DailyPrice = 190,
                Description = "Firma A",
                ModelYear = 2013
            });
        }

        private static void TestCarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
