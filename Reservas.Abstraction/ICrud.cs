using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reservas.Abstraction
{
    public interface ICrudAsync<T>
    {
        Task<T> SaveAsync(T entity);
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int IdOwner);
        void DeleteAsync(int IdOwner);
    }

    public interface ICrud<T> : ICrudAsync<T>
    {
        T Save(T entity);
        IList<T> GetAll();
        T GetById(int id);
        T GetByDescription(string Name);
        void Delete(int id);

    }
}
