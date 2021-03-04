using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(CarImage carImage);
        IDataResult<List<CarImage>> GetSameCars(int carId);
    }
}
