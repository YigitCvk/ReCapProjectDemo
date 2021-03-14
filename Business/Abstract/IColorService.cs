using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        Color GetById(int colorId);
        List<Color> GetAll();
        void Add(Color color);
        void Updated(Color color);
        void Deleted(Color color);
        


    }
}
