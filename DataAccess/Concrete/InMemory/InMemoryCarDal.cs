using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        readonly List<Car> _car;
        public InMemoryCarDal() => _car = new List<Car> {
                new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 300, Description = "1.6 Motor, Manuel Vites, Dizel Yakıt" },
                new Car { CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 200, Description = "1.5 Motor, Manuel Vites, Benzin Yakıt" },
                new Car { CarId = 3, BrandId = 2, ColorId = 2, ModelYear = 2013, DailyPrice = 225, Description = "1.5 Motor, Otomatik Vites, Dizel Yakıt" },
                new Car { CarId = 4, BrandId = 3, ColorId = 3, ModelYear = 2016, DailyPrice = 250, Description = "2.0 Motor, Otomatik Vites, Dizel Yakıt" },

            };

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<TX> Get<TX>(Expression<Func<TX, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarId(int carId)
        {
            return _car.Where(c => c.CarId == carId).ToList();
        }

 
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
