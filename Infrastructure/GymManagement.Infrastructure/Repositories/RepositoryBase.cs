using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GymManagement.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
       private  readonly DbSet<T> _dbSet;
        public RepositoryBase(GymManagementDBContext context)
        {
            _dbSet = context.Set<T>();//Injection
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);//Database kaydetme işlemi

        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public List<T> GetAll()
        {

            return _dbSet.ToList();

        }

        public List<T> Get(Expression<Func<T, bool>> filter = null)
        {
            return _dbSet.Where(filter).ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.SingleOrDefault(p => p.Id == id); //set abone ol
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
