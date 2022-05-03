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
            var beerRepository = new Repository<Beer>(context);
            var beer = new Beer() { Name = "Aguila Ligth", Style = "Strong Ale" };

            beerRepository.Add(beer);
            beerRepository.Save();

            foreach (var item in beerRepository.Get())
            {
                Console.WriteLine(item.Name);
            }

            var brandRepository = new Repository<Brand>(context);
            var brand = new Brand() { Name = "Fuller"};

            brandRepository.Add(brand);
            brandRepository.Save();

            foreach (var item in brandRepository.Get())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
