using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(BranDal branDal)
        {
            _brandDal = branDal;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public void Deleted(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccesResult(Messages.BrandDeleted);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int Id)
        {
            return _brandDal.GetById(b=>b.branId==Id);
        }

        public void Updated(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
