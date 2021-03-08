using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Business;
using Core.Utilities.Helpers;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            BusinessRules.Run(CheckIfCarImageCountLessOrEqualThanFive(carImage.CarId));

            carImage.ImagePath = FileHelper.Add(formFile, @"Images\");
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CarImage carImage)
        {
            
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(CarImage carImage)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == carImage.Id));
        }

        public IDataResult<List<CarImage>> GetSameCars(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(formFile, carImage.ImagePath);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }

        private IResult CheckIfCarImageCountLessOrEqualThanFive(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId && c.ImagePath.EndsWith("jpeg")).Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }

            return new SuccessResult(Messages.ImageAdded);
        }
    }
}
