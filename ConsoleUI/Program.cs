using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"Car ID:{car.CarId}" + " / " + $"Brand ID:{car.BrandId}" + " / " + $"Color ID:{car.ColorId}" + " / "+$"ModelYear:{car.ModelYear}" + " / " + $"Daily Price:{car.DailyPrice}" + " / " + $"Description:{car.Description}");              
            }

            
        }           


    }
}
