using Domain.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        public IQueryable<TEntity> GetAllEmployeeInWard(int wardId);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
        void SaveChanges();
    }
}
