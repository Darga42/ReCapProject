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
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 4, ColorId = 1, CarName = "BMW", DailyPrice = 2800, ModelYear = "2020", Description = "5.28İA" });
            carManager.Add(new Car { Id = 2, BrandId = 28, ColorId = 1, CarName = "Volkswagen", DailyPrice = 1850, ModelYear = "2017", Description = "Golf" });

        }
    }
}
