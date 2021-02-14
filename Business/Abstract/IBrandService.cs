﻿using Core.Utilities.DataResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetByBrandId(int brandId);
        IDataResult<List<Brand>> GetAll();
    }
}