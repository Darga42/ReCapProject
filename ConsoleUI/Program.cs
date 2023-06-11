using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System.Net.Http.Headers;

public class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
        //CarGetByIdTest();
        //BrandTest();
        //ColorTest();
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetCarDetails())
        {
            //Console.WriteLine(car.Description);
            Console.WriteLine("Araç :{0} Marka: {1} Renk: {2}", car.Description, car.BrandName, car.ColorName);
        }
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.Name);
        }
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.Name);
        }
    }

    private static void CarGetByIdTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.GetById(1))
        {
            Console.WriteLine(car.Description);
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}