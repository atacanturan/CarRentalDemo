using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTO_s;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 300, ModelYear = 2015, Description = "Orta Hızlı"},
                new Car{CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = 2018, Description = "Hızlı"},
                new Car{CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 1000, ModelYear = 2010, Description = "Yük Aracı"},
                new Car{CarId = 4, BrandId = 2, ColorId = 4, DailyPrice = 1200, ModelYear = 2012, Description = "Verimli Yük Aracı"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(deletedCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.ModelYear = car.ModelYear;
            updatedCar.Description = car.Description;
        }
    }
}
