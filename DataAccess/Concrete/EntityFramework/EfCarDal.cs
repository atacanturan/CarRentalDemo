using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from cars in context.Cars
                             join b in context.Brands
                             on cars.BrandId equals b.BrandId
                             join colors in context.Colors
                             on cars.ColorId equals colors.ColorId
                             select new CarDetailDto
                             {
                                 CarName = cars.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = colors.ColorName,
                                 DailyPrice = cars.DailyPrice,
                             };

                return result.ToList();
            }
        }
    }
}
