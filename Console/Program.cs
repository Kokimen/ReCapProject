using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll()) 
            {
                System.Console.WriteLine(car.CarId + " Numaralı " + car.BrandId + " Markalı " + car.ColorId + " Renkli " + car.ModelYear + " Model Yılı " + car.DailyPrice + " Günlük Ücretli " + car.Description + " Otomobil ");
            }
           
        }
    }
}
