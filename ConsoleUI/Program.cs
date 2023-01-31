using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarDal inMemorCarDal = new InMemoryCarDal();
            ICarService carService = new CarManager(inMemorCarDal);

            var araclar = carService.GetAll();
            foreach (var c in araclar)
            {
                Console.WriteLine($"         Id : {c.Id}");
                Console.WriteLine($"    BrandId : {c.BrandId}");
                Console.WriteLine($"    ColorId : {c.ColorId}");
                Console.WriteLine($"      Model : {c.ModelYear}");
                Console.WriteLine($"Daily Price : {c.DailyPrice} TL");
                Console.WriteLine($"Description : {c.Description}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
