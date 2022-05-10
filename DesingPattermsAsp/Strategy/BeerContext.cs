using DesignPatterns.Repository;
using DesingPattermsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPattermsAsp.Strategy
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormViewModel beerMV, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerMV, unitOfWork);
        }
    }
}
