﻿using Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Drawing;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Deleted(Color color)
        {
            throw new System.NotImplementedException();
        }

        public List<Color> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Color GetById(int colorId)
        {
            throw new System.NotImplementedException();
        }

        public void Updated(Color color)
        {
            throw new System.NotImplementedException();
        }
    }
}
