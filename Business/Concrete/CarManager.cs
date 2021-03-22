using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Cars car)
        {
            _carsDal.Add(car);
        }

        public List<Cars> GetAll()
        {
            return _carsDal.GetAll();
        }

        public List<Cars> GetCarsByBrandId(int id)
        {
            return _carsDal.GetAll(c => c.BrandId == id);

        }

        public List<Cars> GetCarsByColorId(int id)
        {
            return _carsDal.GetAll(c => c.ColorId == id);
        }

    }
}
