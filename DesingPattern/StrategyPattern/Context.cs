using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;

        //con esto vamos a cambiar el comportamiento de Run, en tiempo de ejecucion, (si esta comportandoce como moto, se puede pasar a comportar como carro).
        public IStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Run()
        {
            _strategy.Run();
        }
    }
}
