using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandsId(int id);
        List<Car> GetByColorsId(int id);
        List<Brand> GetBrandName(int brandId);
        List<Color> GetColorName(int colorId);
        void Add(Car car);
    }
}
