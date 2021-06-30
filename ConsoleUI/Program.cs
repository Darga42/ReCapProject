using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            //BrandTest();
            var carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"Model:{car.CarName} - Brand:{car.BrandName} - Color:{car.ColorName} - DailyPrice:{car.DailyPrice}");
            }

        }

        private static void CarTest()
        {
            var carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 3, BrandId = 29, ColorId = 14, CarName = "Volvo", DailyPrice = 1900, ModelYear = "2019", Description = "XC90" });
            carManager.Update(new Car { Id = 3, BrandId = 29, ColorId = 9, CarName = "Volvo", DailyPrice = 1550, ModelYear = "2016", Description = "S80 2.0T" });
            carManager.Delete(new Car { Id = 3, BrandId = 29, ColorId = 1, CarName = "BMW", DailyPrice = 2800, ModelYear = "2020", Description = "5.28İA" });
        }

        private static void ColorTest()
        {
            var colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 14, ColorName = "Turquoise" });
            colorManager.Update(new Color { Id = 14, ColorName = "Black" });
            colorManager.Delete(new Color { Id = 14 });
        }

        private static void BrandTest()
        {
            var brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 29, BrandName = "Subaru" });
            brandManager.Update(new Brand { Id = 29, BrandName = "Volvo" });
            brandManager.Delete(new Brand { Id = 29 });
        }
    }
}
