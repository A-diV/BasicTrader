using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trader.Models;
using Trader.Services;

namespace Trader.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly TraderDbContextFactory _contextFactory;

        public GenericDataService(TraderDbContextFactory traderDbContextFactory)
        {
            _contextFactory = traderDbContextFactory;
        }

        public async Task<T> Create(T entity)
        {
           using(var context = _contextFactory.CreateDbContext())
           {
               EntityEntry<T> createdResult= await context.Set<T>().AddAsync(entity);
               await context.SaveChangesAsync();

                return createdResult.Entity;
           }
        }

        public async Task<bool> Delete(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.id == id);
                context.Set<T>().Remove(entity);

                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.id == id);

                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();

                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                entity.id = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
