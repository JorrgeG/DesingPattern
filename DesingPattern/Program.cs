using DesingPattern.FactoryMethod;
using DesingPattern.Models;
using System;
using System.Linq;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DesignPatternsContext();
            var lst = context.Beers.ToList();

            foreach(var beer in lst)
            {
                Console.WriteLine(beer.Name);
            }
        }
    }
}
