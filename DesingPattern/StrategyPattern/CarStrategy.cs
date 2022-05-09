using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyPattern
{
    public class CarStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un carro y me muevo con 4 llantas");
        }
    }
}
