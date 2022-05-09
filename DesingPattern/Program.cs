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
            // principios SOLID:
            // 1- Abierto y cerrado: nos dice que una clase deberia estar abierta a extencion pero cerrada a modificacion.
            // 2- Responsabilidad unica: nose como se le da el comportamiento al objeto, pero seguira corriendo, en este ejemplo



            var context = new Context(new CarStrategy());
            context.Run();

            context.Strategy = new MotorcyleStrategy();
            context.Run();
        }
    }
}
