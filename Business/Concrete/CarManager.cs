using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Concrete.EntityFramework;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public CarManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public CarManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 200 && car.ModelYear > 2015)
            {
                _carDal.Add(car);
                Console.WriteLine("Ürün eklendi.");
            }
            else
            {
                Console.WriteLine("Şartlar uyuşmuyor.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Brand> GetBrandName(int brandId)
        {
            return _brandDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetByBrandsId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetByColorsId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Color> GetColorName(int colorId)
        {
            return _colorDal.GetAll(p => p.ColorId == colorId);
        }
    }
}
