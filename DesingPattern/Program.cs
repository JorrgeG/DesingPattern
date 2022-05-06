using DesingPattern.FactoryMethod;
using DesingPattern.Models;
using DesingPattern.RepositoryPattern;
using DesingPattern.UnitofWorkPattern;
using System;
using System.Linq;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DesignPatternsContext();
            var unitOfWork = new UnitOfWork(context);
            var beers = unitOfWork.Beers;
            var beer = new Beer()
            {
                Name = "Poker Doble Malta",
                Style = "Porter"
            };
            beers.Add(beer);

            var brands = unitOfWork.Brands;
            var brand = new Brand()
            {
                Name = "Clud Doble Malta",
            };
            brands.Add(brand);

            unitOfWork.Save();
        }
    }
}
