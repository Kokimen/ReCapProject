using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using DataAccess.Concrete.EntityFramework.Repository;

namespace Console
{
    class Program
    {
        static void Main()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll()) 
            {
                System.Console.WriteLine(car.CarId + " Numaralı " + car.BrandId + " Markalı " + car.ColorId + " Renkli " + car.ModelYear + " Model Yılı " + car.DailyPrice + " Günlük Ücretli " + car.Description + " Otomobil ");
            }
           
        }
    }
}
