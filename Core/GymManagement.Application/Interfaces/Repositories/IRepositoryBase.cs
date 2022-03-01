using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GymManagement.Application.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        List<T> GetAll();//herşeyi bütün veriyi istiyoruz 
        List<T> Get(Expression<Func<T, bool>> filter = null);
        //Expression<Func> eklenecek
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
