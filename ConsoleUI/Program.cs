using Business.Concrete;
using DataAccess.Concrete.InMemoryCarDal;
using System.Net.Http.Headers;

public class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }

    }
}