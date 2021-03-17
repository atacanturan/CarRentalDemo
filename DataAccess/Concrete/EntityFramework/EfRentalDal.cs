using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalInfos()
        {
            using (var context = new RecapContext())
            {
                var result = from rentals in context.Rentals
                    join cars in context.Cars
                        on rentals.CarId equals cars.CarId
                    join customers in context.Customers
                        on rentals.CustomerId equals customers.CustomerId
                    select new RentalDetailDto
                    {
                        CarName = cars.CarName, CompanyName = customers.CompanyName, RentDate = rentals.RentDate,
                        ReturnDate = rentals.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
