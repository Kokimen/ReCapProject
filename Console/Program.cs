using System;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Console
{
    public static class Program
    {
        private static void Main()
        {
            //CarGetAllTest();
            //AddCustomerTest();
            //CustomerGetAllTest();
            //CarGetDetailsTest();
            RentCarTest();
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
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                System.Console.WriteLine(result.Message);
                foreach (var car in carManager.GetAll().Data)
                {
                    System.Console.WriteLine(car.CarId + " Numaralı " + car.BrandId + " Markalı " + car.ColorId +
                                             " Renkli " + car.ModelYear + " Model Yılı " + car.DailyPrice +
                                             " Günlük Ücretli " + car.Description + " Otomobil ");
                }
            }
        }

        private static void AddCustomerTest()
        {
            var customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer {UserId = 1, CompanyName = "Bosch" });
            customerManager.Add(new Customer {UserId = 2, CompanyName = "Aygaz" });
            customerManager.Add(new Customer {UserId = 3, CompanyName = "Aselsan" });
        }

        private static void CustomerGetAllTest()
        {
            var customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                System.Console.WriteLine(customer.CustomerId + " / " + customer.UserId + " / " + customer.CompanyName);
            }
        }

        private static void RentCarTest()
        {
            var rentManager = new RentManager(new EfRentDal());
            var result = rentManager.Add(new Rent {CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null});
            System.Console.WriteLine(result.Message);
            
            //foreach (var rent in rentManager.GetAll().Data)
            //{
                
            //    System.Console.WriteLine(rent.CarId);

            //}
        } //sıkıntı var
    }
}
