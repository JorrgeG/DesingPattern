using DesingPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.RepositoryPattern
{
    class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _Context;

        public BeerRepository(DesignPatternsContext context)
        {
            _Context = context;
        }

        public void Add(Beer data)
        {
            _Context.Beers.Add(data);
        }

        public void Delete(int id)
        {
            var beer = _Context.Beers.Find(id);
            _Context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get()
        {
            return _Context.Beers.ToList();
        }

        public Beer Get(int id)
        {
            return _Context.Beers.Find(id);
        }

        public void Save()
        {
            _Context.SaveChanges(); //sino se ejecuta esta parte, no se veran resultados en la bd
        }
    }
}
