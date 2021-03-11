using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using Core.Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCarGetAll();
            //AddCar();
            //UpdateCar();
            //AddCustomer();
            //AddUser();
            //RentCar();
            
        }

        private static void RentCar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var rentingCar1 = rentalManager.Add(new Rental
            {
                CarId = 4,
                CustomerId = 2,
                RentDate = DateTime.Now
            });
            var rentingCar2 = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 2,
                RentDate = DateTime.Now
            });
            Console.WriteLine($"Araba 1 kiralama durumu: {rentingCar1.Message}\nAraba 2 kiralama durumu: {rentingCar2.Message}");
        }

        private static void AddUser()
        {
            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User
            //{
            //    FirstName = "Atacan",
            //    LastName = "Turan",
            //    CustomerId = 1,
            //    Email = "atacanturan@hotmail.com",
            //    Password = "123456"
            //});
        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "Fiction"
            });
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
