using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesingPattermsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPattermsAsp.Strategy
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormViewModel beerM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerM.Name;
            beer.Style = beerM.Style;
            beer.BrandId = (Guid)beerM.BrandId;

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
