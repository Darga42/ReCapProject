using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using System.Net.Http.Headers;

public class Program
{
    private static void Main(string[] args)
    {
        CarTest();
        CarGetByIdTest();
        
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