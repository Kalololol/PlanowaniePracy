using Domain.Entities.Entity;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly AppDbContext _context;
        private DbSet<TEntity> entities;

        public Repository(AppDbContext context)
        {
            this._context = context;
            this.entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
            SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
            SaveChanges();
        }
        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.Where(predicate);
        }
        public IQueryable<TEntity> GetAll()
        {
            return entities;
        }
        public TEntity GetById(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }
        public void Update(TEntity entity)
        {
            entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
