using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Console
{
    class Program
    {
        static void Main()
        {
            //CarGetAllTest();

            CarGetDetailsTest();
        }

        private static void CarGetDetailsTest()
        {
            var carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                System.Console.WriteLine(
                    $"{car.CarId}--{car.BrandName}--{car.ColorName}--{car.DailyPrice}--{car.Description}");
            }
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                System.Console.WriteLine(car.CarId + " Numaralı " + car.BrandId + " Markalı " + car.ColorId +
                                         " Renkli " + car.ModelYear + " Model Yılı " + car.DailyPrice +
                                         " Günlük Ücretli " + car.Description + " Otomobil ");
            }
        }
    }
}
