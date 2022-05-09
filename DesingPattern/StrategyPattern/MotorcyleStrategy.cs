using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyPattern
{
    public class MotorcyleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy un moto y me muevo con 2 llantas");
        }
    }
}
