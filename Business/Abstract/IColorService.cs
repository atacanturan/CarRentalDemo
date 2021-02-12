using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        Color GetByColorId(int colorId);
        List<Color> GetAll();
    }
}
