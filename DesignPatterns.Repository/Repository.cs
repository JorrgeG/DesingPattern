using DesignPatterns.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DesignPatternsContext _Context;
        private DbSet<TEntity> _dbSet;

        public Repository(DesignPatternsContext context)
        {
            _Context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            _dbSet.Remove(dataToDelete);
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _Context.Entry(data).State = EntityState.Modified;
        }
    }
}
