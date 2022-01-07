using Reservas.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reservas.Repository
{
    public interface IRepositoryVuelo<T> : ICrud<T>
    {
    }
    public class RepositoryVuelo<T> : IRepositoryVuelo<T> where T : IVuelo
    {

        IDbContext<T> _ctx;

        public RepositoryVuelo(IDbContext<T> ctx)
        {
            _ctx = ctx;
        }

        public void Delete(int id)
        {
            _ctx.Delete(id);
        }

        public void DeleteAsync(int id)
        {
            _ctx.DeleteAsync(id);
        }

        public IList<T> GetAll()
        {
            return _ctx.GetAll();
        }

        public Task<IList<T>> GetAllAsync()
        {
            return _ctx.GetAllAsync();
        }

        public T GetById(int id)
        {
            return _ctx.GetById(id);
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _ctx.GetByIdAsync(id);
        }

        public T Save(T entity)
        {
            return _ctx.Save(entity);
        }

        public Task<T> SaveAsync(T entity)
        {
            return _ctx.SaveAsync(entity);
        }
        public T GetByDescription(string Description)
        {
            return _ctx.GetByDescription(Description);
        }
    }
}
