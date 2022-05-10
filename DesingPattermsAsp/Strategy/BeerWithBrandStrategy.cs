using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesingPattermsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPattermsAsp.Strategy
{
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormViewModel beerM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer();
            beer.Name = beerM.Name;
            beer.Style = beerM.Style;

            var brand = new Brand();
            brand.Name = beerM.OtherBrand;
            brand.BrandId = Guid.NewGuid();
            beer.BrandId = brand.BrandId;

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);

            unitOfWork.Save();
        }
    }
}
