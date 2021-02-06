using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 300, ModelYear = 2015, Description = "Orta Hızlı"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = 2018, Description = "Hızlı"},
                new Car{Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 1000, ModelYear = 2010, Description = "Yük Aracı"},
                new Car{Id = 4, BrandId = 2, ColorId = 4, DailyPrice = 1200, ModelYear = 2012, Description = "Verimli Yük Aracı"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.Description = car.Description;
        }
    }
}
