using Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Abstract
{
    public interface ICarService
    {
        List<Cars> GetAll();

        List<Cars> GetCarsByBrandId(int id);
        List<Cars> GetCarsByColorId(int id);
        void Add(Cars car);

    }
}
