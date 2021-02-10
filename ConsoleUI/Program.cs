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
            CarManager carManager = new CarManager(new EfCarDal());
            CarManager carManager1 = new CarManager(new EfBrandDal());

            foreach (var car in carManager.GetByBrandsId(5))
            {
                foreach (var brand in carManager1.GetBrandName(car.BrandId))
                {
                    Console.WriteLine(brand.BrandName);
                }
            }

            CarManager carManager2 = new CarManager(new EfCarDal());

            carManager2.Add(new Car { BrandId = 2, ColorId = 5, DailyPrice = 300, ModelYear = 2017, Description = "Firma C" });

            carManager2.Add(new Car { BrandId = 3, ColorId = 1, DailyPrice = 150, ModelYear = 2014, Description = "Firma A" });
        }
    }
}
