using DesingPattern.FactoryMethod;
using DesingPattern.Models;
using DesingPattern.RepositoryPattern;
using System;
using System.Linq;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DesignPatternsContext();
            var beerRepository = new BeerRepository(context);
            var beer = new Beer();
            beer.Style = "Pilsner";
            beer.Name = "Corona";

            beerRepository.Add(beer);
            beerRepository.Save();

            foreach (var item in beerRepository.Get())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
