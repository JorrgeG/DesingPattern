using DesingPattern.BuilderPattern;
using DesingPattern.FactoryMethod;
using DesingPattern.Models;
using DesingPattern.RepositoryPattern;
using DesingPattern.StrategyPattern;
using DesingPattern.UnitofWorkPattern;
using System;
using System.Linq;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarbanDirector(builder);

            barmanDirector.PrepareMargarita();

            var preparedDrink = builder.GetPrepareDrink();
            Console.WriteLine(preparedDrink.Result);
        }
    }
}
