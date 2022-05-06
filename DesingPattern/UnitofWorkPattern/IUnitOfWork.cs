using DesingPattern.Models;
using DesingPattern.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.UnitofWorkPattern
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }
        public IRepository<Brand> Brands { get; }

        public void Save();
    }
}
