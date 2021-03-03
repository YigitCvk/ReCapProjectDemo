using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {

        List<T> GetById(int carId);
        List<T> GetAll();
    }
}
