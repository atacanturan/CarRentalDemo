using Core.Utilities.DataResults;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetByColorId(int colorId);
        IDataResult<List<Color>> GetAll();
    }
}
