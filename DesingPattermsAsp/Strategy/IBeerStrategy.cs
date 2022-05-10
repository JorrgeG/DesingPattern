using DesignPatterns.Repository;
using DesingPattermsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPattermsAsp.Strategy
{
    public interface IBeerStrategy
    {
        public void Add(FormViewModel beerM, IUnitOfWork unitOfWork);
    }
}
