using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            if (entity.Description.Length > 2 && entity.DailyPrices > 0)
            {
                using (ReCapDemoDbContex1 context = new ReCapDemoDbContex1())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            else
                Console.WriteLine("Girdiginiz değerlere uyan bir araç olamaz.");
        }

        public void Delete(Car entity)
        {
           using(ReCapDemoDbContex1 context=new ReCapDemoDbContex1())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDemoDbContex1 context = new ReCapDemoDbContex1())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDemoDbContex1 context = new ReCapDemoDbContex1())
            {
                return filter == null
                    ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapDemoDbContex1 context = new ReCapDemoDbContex1())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

        
    }

